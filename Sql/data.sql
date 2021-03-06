USE [DroneDelivery]
GO
INSERT [dbo].[Drones] ([Id], [Capacidade], [Velocidade], [Autonomia], [Carga], [Status], [HoraCarregamento]) VALUES (N'f19d1713-f58a-431a-b345-08d846ad7a06', 12000, 3.33333, 35, 60, 1, NULL)
INSERT [dbo].[Drones] ([Id], [Capacidade], [Velocidade], [Autonomia], [Carga], [Status], [HoraCarregamento]) VALUES (N'f65a2242-66b4-4fd5-8a1d-08d846b133e1', 12000, 3.33333, 35, 60, 2, NULL)
INSERT [dbo].[Drones] ([Id], [Capacidade], [Velocidade], [Autonomia], [Carga], [Status], [HoraCarregamento]) VALUES (N'259462a2-c774-48ba-8a1e-08d846b133e1', 12000, 3.33333, 35, 60, 3, NULL)
INSERT [dbo].[Drones] ([Id], [Capacidade], [Velocidade], [Autonomia], [Carga], [Status], [HoraCarregamento]) VALUES (N'ab887d57-3fc1-4444-8a1f-08d846b133e1', 12000, 3.33333, 35, 60, 4, NULL)
INSERT [dbo].[Pedidos] ([Id], [Peso], [DataPedido], [Latitude], [Longitude], [Status], [DroneId]) VALUES (N'ba65318b-158b-4e7b-742c-08d846ae9090', 10, CAST(0x070000000000000000 AS DateTime2), -23.5753639, -46.692417, 1, NULL)
INSERT [dbo].[Pedidos] ([Id], [Peso], [DataPedido], [Latitude], [Longitude], [Status], [DroneId]) VALUES (N'7f9ac940-87aa-486e-40f8-08d846aef1d0', 10, CAST(0x070000000000000000 AS DateTime2), -23.5870753, -46.6520421, 0, N'f19d1713-f58a-431a-b345-08d846ad7a06')
