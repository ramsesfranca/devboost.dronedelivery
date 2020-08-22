using DroneDelivery.Domain.Core;
using DroneDelivery.Domain.Enum;
using Geolocation;
using System;

namespace DroneDelivery.Domain.Entidades
{
    public class Pedido : EntidadeBase<Guid>
    {
        public double Peso { get; }

        public DateTime DataPedido { get; }
        public double Latitude { get; }
        public double Longitude { get; }
        public PedidoStatus Status { get; private set; }

        public Guid? DroneId { get; set; }
        public Drone Drone { get; set; }

        public Pedido(double peso, DateTime dataPedido, double latitude, double longitude, PedidoStatus status)
        {
            Peso = peso;
            DataPedido = dataPedido;
            Longitude = longitude;
            Latitude = latitude;
            Status = status;
        }

        public void AtualizarStatusPedido(PedidoStatus status)
        {
            Status = status;
        }


        public bool ValidarPesoPedido(double carga)
        {
            return Peso < carga;
        }

        public bool ValidarDistanciaEntrega(double latitudeInicial, double longitudeInicial, double velocidadeDrone, double autonomiaDrone)
        {
            double distance = GeoCalculator.GetDistance(latitudeInicial, longitudeInicial, Latitude, Longitude, 1, DistanceUnit.Meters);

            if (distance <= 0)
            {
                return false;
            }

            //velocidade em m/s
            //T = d / v
            var tempoEmMinutos = ((distance * 2) / velocidadeDrone) / 60;

            return !(tempoEmMinutos > autonomiaDrone);
        }
    }
}
