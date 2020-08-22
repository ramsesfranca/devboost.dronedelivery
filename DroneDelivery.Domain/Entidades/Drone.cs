using DroneDelivery.Domain.Core;
using DroneDelivery.Domain.Enum;
using System;
using System.Collections.Generic;

namespace DroneDelivery.Domain.Entidades
{
    public class Drone : EntidadeBase<Guid>
    {

        public double Capacidade { get; }

        public double Velocidade { get; }

        public double Autonomia { get; }

        public double Carga { get; }

        public DateTime? HoraCarregamento { get; private set; }

        public ICollection<Pedido> Pedidos { get; set; }

        public DroneStatus Status { get; set; }

        public Drone(Guid id, double capacidade, double velocidade, double autonomia, double carga, DroneStatus status)
        {
            Id = id;
            Capacidade = capacidade;
            Velocidade = velocidade;
            Autonomia = autonomia;
            Carga = carga;
            Status = status;
        }

        public void AtualizarStatusDrone(DroneStatus status)
        {
            Status = status;
        }

        public void AdicionarDroneParaCarregar()
        {
            HoraCarregamento = DateTime.Now;
        }

        public void LiberarDroneCarregado()
        {
            HoraCarregamento = null;
        }

        public bool VerificarDroneAceitaOPesoPedido(double pesoPedido)
        {
            return Capacidade > pesoPedido * 1000;
        }
    }
}
