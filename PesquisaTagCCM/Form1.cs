using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesquisaTagCCM
{
    public partial class Form1 : Form
    {
        List<Motor> motoresBkp = new List<Motor>();
        List<Motor> motores = new List<Motor>();

        public Form1()
        {
            InitializeComponent();

            #region Dados
            motoresBkp.Add(new Motor("1001", "C4	", "33110-M-1050	", "Rotor 1 pulper seco                                       "));
            motoresBkp.Add(new Motor("1001", "C5	", "33110-M-1051	", "Rotor 2 pulper seco                                       "));
            motoresBkp.Add(new Motor("1001", "C8	", "33110-M-1019	", "Depurador primário 1 ms-1200                              "));
            motoresBkp.Add(new Motor("1001", "C9	", "33110-M-1020	", "Depurador primário 2 ms-1200                              "));
            motoresBkp.Add(new Motor("1002", "G8C	", "33110-M-1024	", "Depurador terciário                                       "));
            motoresBkp.Add(new Motor("1002", "G9F	", "33110-M-1002	", "Agitador 1 torre estocagem                                "));
            motoresBkp.Add(new Motor("1002", "G9F	", "33110-M-1003	", "Agitador 2 torre estocagem                                "));
            motoresBkp.Add(new Motor("1002", "G9G	", "33110-M-1008	", "Agitador 1 tanque mistura                                 "));
            motoresBkp.Add(new Motor("1002", "G10D	", "33110-M-1022	", "Depurador secundário                                      "));
            motoresBkp.Add(new Motor("1002", "G11B	", "33110-M-1125	", "Esticador automatico da tela inferior                     "));
            motoresBkp.Add(new Motor("1002", "G12A	", "33110-M-1122	", "Sistema de ajuste do lábio da caixa de entrada            "));
            motoresBkp.Add(new Motor("1002", "G12B	", "33110-M-1133	", "Unidade de sucção formador mb                             "));
            motoresBkp.Add(new Motor("1002", "G12C	", "33110-M-1132	", "Esticador tela superior                                   "));
            motoresBkp.Add(new Motor("1002", "G13A	", "33110-M-1123	", "Sistema de abertura da caixa de entrada                   "));
            motoresBkp.Add(new Motor("1002", "G13D	", "33110-M-1127	", "Pichasso da ponta lado acionamento                        "));
            motoresBkp.Add(new Motor("1003", "G4A	", "33110-M-1004	", "Agitador torre estocagem                                      "));
            motoresBkp.Add(new Motor("1003", "G5C	", "33110-M-1005	", "Agitador torre estocagem                                      "));
            motoresBkp.Add(new Motor("1003", "G5D	", "33110-M-1009	", "Agitador tanque mistura                                       "));
            motoresBkp.Add(new Motor("1003", "G5F	", "33110-M-1023	", "Depurador                                                     "));
            motoresBkp.Add(new Motor("1003", "G6B	", "33110-M-1080	", "Soprador sucção pick up                                       "));
            motoresBkp.Add(new Motor("1003", "G7D	", "33110-M-1061	", "Soprador caixa baixo                                          "));
            motoresBkp.Add(new Motor("1003", "G7E	", "33110-M-1083	", "Soprador sucção rolo couch                                    "));
            motoresBkp.Add(new Motor("1003", "G8C	", "33110-M-1055	", "Filtro gravidade feltros                                      "));
            motoresBkp.Add(new Motor("1003", "G8D	", "33110-M-1064	", "Soprador formador mb                                          "));
            motoresBkp.Add(new Motor("1003", "G9B	", "33110-M-1038	", "Agitador torre de quebra                                      "));
            motoresBkp.Add(new Motor("1003", "G9D	", "33110-M-1045	", "Rotor 1 pulper úmido                                          "));
            motoresBkp.Add(new Motor("1003", "G10C	", "33110-M-1102	", "TRO água selagem bomba vácuo                              "));
            motoresBkp.Add(new Motor("1003", "G10G	", "33110-M-1317	", "Resistência aquecimento U.H                               "));
            motoresBkp.Add(new Motor("1003", "G11B	", "33110-M-1128	", "Pichasso da ponta lado controle                           "));
            motoresBkp.Add(new Motor("1003", "G11C	", "33110-M-1126	", "Esticador manual da tela inferior                         "));
            motoresBkp.Add(new Motor("1005", "G3A	", "33100-M-0007	", "Insuflador de ar do teto falso 1                              "));
            motoresBkp.Add(new Motor("1005", "G3B	", "33100-M-0037	", "Ventilador 2 da unidade de ventilação 3                       "));
            motoresBkp.Add(new Motor("1005", "G3C	", "33100-M-0014	", "Ventilador 1 da unidade de ventilação 1                       "));
            motoresBkp.Add(new Motor("1005", "G3D	", "33100-M-0015	", "Ventilador 2 da unidade de ventilação 1                       "));
            motoresBkp.Add(new Motor("1005", "G3E	", "33100-M-0016	", "Ventilador 3 da unidade de ventilação 1                       "));
            motoresBkp.Add(new Motor("1005", "G3F	", "33100-M-0017	", "Ventilador 4 da unidade de ventilação 1                       "));
            motoresBkp.Add(new Motor("1005", "G3G	", "33100-M-0018	", "Ventilador 5 da unidade de ventilação 1                       "));
            motoresBkp.Add(new Motor("1005", "G3H	", "33100-M-0019	", "Ventilador 6 da unidade de ventilação 1                       "));
            motoresBkp.Add(new Motor("1005", "G3I	", "33100-M-0025	", "Ventilador 1 da unidade de ventilação 2                       "));
            motoresBkp.Add(new Motor("1005", "G3J	", "33100-M-0026	", "Ventilador 2 da unidade de ventilação 2                       "));
            motoresBkp.Add(new Motor("1005", "G3K	", "33100-M-0027	", "Ventilador 3 da unidade de ventilação 2                       "));
            motoresBkp.Add(new Motor("1005", "G4A	", "33110-M-1625	", "Ventilador de circulação de ar 1 lado seco torre final        "));
            motoresBkp.Add(new Motor("1005", "G5A	", "33110-M-1626	", "Ventilador de circulação de ar 2 lado seco torre final        "));
            motoresBkp.Add(new Motor("1005", "G6A	", "33110-M-1637	", "Exaustor de ar 4                                              "));
            motoresBkp.Add(new Motor("1005", "G7A	", "33110-M-1641	", "Ventilador de insuflamento de ar 4                            "));
            motoresBkp.Add(new Motor("1005", "G8A	", "33110-M-1013	", "Agitador do tanque de máquina                                 "));
            motoresBkp.Add(new Motor("1005", "G9A	", "33110-M-1557	", "Ventilador de circ de ar T23-3                                "));
            motoresBkp.Add(new Motor("1005", "G9B	", "33110-M-1558	", "Ventilador de circ de ar T23-4                                "));
            motoresBkp.Add(new Motor("1005", "G9C	", "33110-M-1559	", "Ventilador de circ de ar T23-5                                "));
            motoresBkp.Add(new Motor("1005", "G9D	", "33110-M-1560	", "Ventilador de circ de ar T23-6                                "));
            motoresBkp.Add(new Motor("1005", "G9E	", "33110-M-1561	", "Ventilador de circ de ar T23-7                                "));
            motoresBkp.Add(new Motor("1005", "G9F	", "33110-M-1562	", "Ventilador de circ de ar T23-8                                "));
            motoresBkp.Add(new Motor("1005", "G9G	", "33110-M-1563	", "Ventilador de circ de ar T23-9                                "));
            motoresBkp.Add(new Motor("1005", "G9H	", "33110-M-1555	", "Ventilador de circ de ar T23-1                                "));
            motoresBkp.Add(new Motor("1005", "G9I	", "33110-M-1556	", "Ventilador de circ de ar T23-2                                "));
            motoresBkp.Add(new Motor("1005", "G10A	", "33100-M-0028	", "Ventilador 4 da unidade de ventilação 2                   "));
            motoresBkp.Add(new Motor("1005", "G10B	", "33100-M-0029	", "Ventilador 5 da unidade de ventilação 2                   "));
            motoresBkp.Add(new Motor("1005", "G10C	", "33100-M-0030	", "Ventilador 6 da unidade de ventilação 2                   "));
            motoresBkp.Add(new Motor("1005", "G10D	", "33100-M-0036	", "Ventilador 1 da unidade de ventilação 3                   "));
            motoresBkp.Add(new Motor("1005", "G10E	", "33100-M-0038	", "Ventilador 3 da unidade de ventilação 3                   "));
            motoresBkp.Add(new Motor("1005", "G10F	", "33100-M-0039	", "Ventilador 4 da unidade de ventilação 3                   "));
            motoresBkp.Add(new Motor("1005", "G10G	", "33100-M-0040	", "Ventilador 5 da unidade de ventilação 3                   "));
            motoresBkp.Add(new Motor("1005", "G10H	", "33100-M-0041	", "Ventilador 6 da unidade de ventilação 3                   "));
            motoresBkp.Add(new Motor("1005", "G10I	", "33100-M-0047	", "Ventilador 1 da unidade de ventilação 4                   "));
            motoresBkp.Add(new Motor("1005", "G10J	", "33100-M-0048	", "Ventilador 2 da unidade de ventilação 4                   "));
            motoresBkp.Add(new Motor("1005", "G10K	", "33100-M-0049	", "Ventilador 3 da unidade de ventilação 4                   "));
            motoresBkp.Add(new Motor("1005", "G11A	", "33100-M-0050	", "Ventilador 4 da unidade de ventilação 4                   "));
            motoresBkp.Add(new Motor("1005", "G11B	", "33100-M-0051	", "Ventilador 5 da unidade de ventilação 4                   "));
            motoresBkp.Add(new Motor("1005", "G11C	", "33100-M-0052	", "Ventilador 6 da unidade de ventilação 4                   "));
            motoresBkp.Add(new Motor("1005", "G11D	", "33100-M-0058	", "Ventilador 1 da unidade de ventilação 5                   "));
            motoresBkp.Add(new Motor("1005", "G11E	", "33100-M-0059	", "Ventilador 2 da unidade de ventilação 5                   "));
            motoresBkp.Add(new Motor("1005", "G11F	", "33100-M-0060	", "Ventilador 3 da unidade de ventilação 5                   "));
            motoresBkp.Add(new Motor("1005", "G11G	", "33100-M-0061	", "Ventilador 4 da unidade de ventilação 5                   "));
            motoresBkp.Add(new Motor("1005", "G11H	", "33100-M-0062	", "Ventilador 5 da unidade de ventilação 5                   "));
            motoresBkp.Add(new Motor("1005", "G11I	", "33100-M-0063	", "Ventilador 6 da unidade de ventilação 5                   "));
            motoresBkp.Add(new Motor("1005", "G12A	", "33100-M-3224	", "Ventilador 1 da unidade de circulação de ar 1             "));
            motoresBkp.Add(new Motor("1005", "G12B	", "33100-M-3225	", "Ventilador 2 da unidade de circulação de ar 1             "));
            motoresBkp.Add(new Motor("1005", "G12C	", "33100-M-3226	", "Ventilador 3 da unidade de circulação de ar 1             "));
            motoresBkp.Add(new Motor("1005", "G12D	", "33100-M-3227	", "Ventilador 4 da unidade de circulação de ar 1             "));
            motoresBkp.Add(new Motor("1005", "G12E	", "33100-M-3228	", "Ventilador 5 da unidade de circulação de ar 1             "));
            motoresBkp.Add(new Motor("1005", "G12F	", "33100-M-3229	", "Ventilador 6 da unidade de circulação de ar 1             "));
            motoresBkp.Add(new Motor("1005", "G12G	", "33100-M-3233	", "Ventilador 1 da unidade de circulação de ar 2             "));
            motoresBkp.Add(new Motor("1005", "G12H	", "33100-M-3234	", "Ventilador 2 da unidade de circulação de ar 2             "));
            motoresBkp.Add(new Motor("1005", "G12I	", "33100-M-3235	", "Ventilador 3 da unidade de circulação de ar 2             "));
            motoresBkp.Add(new Motor("1005", "G12J	", "33100-M-3236	", "Ventilador 4 da unidade de circulação de ar 2             "));
            motoresBkp.Add(new Motor("1005", "G12K	", "33100-M-3237	", "Ventilador 5 da unidade de circulação de ar 2             "));
            motoresBkp.Add(new Motor("1005", "G13A	", "33100-M-3238	", "Ventilador 6 da unidade de circulação de ar 2             "));
            motoresBkp.Add(new Motor("1005", "G13B	", "33100-M-3268	", "Ventilador de ar 1 - exaustão do prédio                   "));
            motoresBkp.Add(new Motor("1005", "G13C	", "33100-M-3269	", "Ventilador de ar 2 - exaustão do prédio                   "));
            motoresBkp.Add(new Motor("1005", "G13D	", "33100-M-3270	", "Ventilador de ar 3 - exaustão do prédio                   "));
            motoresBkp.Add(new Motor("1005", "G13E	", "33100-M-3271	", "Ventilador de ar 4 - exaustão do prédio                   "));
            motoresBkp.Add(new Motor("1005", "G13F	", "33100-M-3272	", "Ventilador de ar 5 - exaustão do prédio                   "));
            motoresBkp.Add(new Motor("1005", "G13G	", "33100-M-3273	", "Ventilador de ar 6 - exaustão do prédio                   "));
            motoresBkp.Add(new Motor("1005", "G13H	", "33100-M-3274	", "Ventilador de ar 7 - exaustão do prédio                   "));
            motoresBkp.Add(new Motor("1005", "G13I	", "33100-M-3275	", "Ventilador de ar 8 - exaustão do prédio                   "));
            motoresBkp.Add(new Motor("1005", "G13J	", "33100-M-3276	", "Ventilador de ar 9 - exaustão do prédio                   "));
            motoresBkp.Add(new Motor("1005", "G13K	", "33100-M-3277	", "Ventilador de ar 10 - exaustão do prédio                  "));
            motoresBkp.Add(new Motor("1005", "G14A	", "33100-M-3282	", "Ventilador de ar 15 - exaustão do prédio                  "));
            motoresBkp.Add(new Motor("1005", "G14B	", "33100-M-3283	", "Ventilador de ar 16 - exaustão do prédio                  "));
            motoresBkp.Add(new Motor("1005", "G14C	", "33100-M-3284	", "Ventilador de ar 17 - exaustão do prédio                  "));
            motoresBkp.Add(new Motor("1005", "G14D	", "33100-M-3285	", "Ventilador 1 - poço do pulper                             "));
            motoresBkp.Add(new Motor("1005", "G14E	", "33100-M-3286	", "Ventilador 2 - poço do pulper                             "));
            motoresBkp.Add(new Motor("1005", "G14F	", "33100-M-3289	", "Resfriador de ar 1 - piso operacional                     "));
            motoresBkp.Add(new Motor("1005", "G14G	", "33100-M-3290	", "Resfriador de ar 2 - piso operacional                     "));
            motoresBkp.Add(new Motor("1005", "G14H	", "33100-M-3291	", "Resfriador de ar 3 - piso operacional                     "));
            motoresBkp.Add(new Motor("1005", "G16A	", "33110-M-1564	", "Ventilador de circ de ar T23-10                           "));
            motoresBkp.Add(new Motor("1005", "G16B	", "33110-M-1572	", "Ventilador de circ de ar T24-8                            "));
            motoresBkp.Add(new Motor("1005", "G16C	", "33110-M-1567	", "Ventilador de circ de ar T24-3                            "));
            motoresBkp.Add(new Motor("1005", "G16D	", "33110-M-1568	", "Ventilador de circ de ar T24-4                            "));
            motoresBkp.Add(new Motor("1005", "G16E	", "33110-M-1569	", "Ventilador de circ de ar T24-5                            "));
            motoresBkp.Add(new Motor("1005", "G16F	", "33110-M-1570	", "Ventilador de circ de ar T24-6                            "));
            motoresBkp.Add(new Motor("1005", "G16G	", "33110-M-1571	", "Ventilador de circ de ar T24-7                            "));
            motoresBkp.Add(new Motor("1005", "G16H	", "33110-M-1566	", "Ventilador de circ de ar T24-2                            "));
            motoresBkp.Add(new Motor("1005", "G16I	", "33110-M-1565	", "Ventilador de circ de ar T24-1                            "));
            motoresBkp.Add(new Motor("1005", "G17A	", "33110-M-1573	", "Ventilador de circ de ar T24-9                            "));
            motoresBkp.Add(new Motor("1005", "G17B	", "33110-M-1574	", "Ventilador de circ de ar T24-10                           "));
            motoresBkp.Add(new Motor("1005", "G17C	", "33110-M-1577	", "Ventilador de circ de ar T25-3                            "));
            motoresBkp.Add(new Motor("1005", "G17D	", "33110-M-1578	", "Ventilador de circ de ar T25-4                            "));
            motoresBkp.Add(new Motor("1005", "G17E	", "33110-M-1579	", "Ventilador de circ de ar T25-5                            "));
            motoresBkp.Add(new Motor("1005", "G17F	", "33110-M-1580	", "Ventilador de circ de ar T25-6                            "));
            motoresBkp.Add(new Motor("1005", "G17G	", "33110-M-1581	", "Ventilador de circ de ar T25-7                            "));
            motoresBkp.Add(new Motor("1005", "G17H	", "33110-M-1576	", "Ventilador de circ de ar T25-2                            "));
            motoresBkp.Add(new Motor("1005", "G17I	", "33110-M-1575	", "Ventilador de circ de ar T25-1                            "));
            motoresBkp.Add(new Motor("1005", "G18D	", "33110-M-1585	", "Ventilador de circ de ar T26-1                            "));
            motoresBkp.Add(new Motor("1005", "G18E	", "33110-M-1586	", "Ventilador de circ de ar T26-2                            "));
            motoresBkp.Add(new Motor("1005", "G18F	", "33110-M-1595	", "Ventilador de circ de ar T27-1                            "));
            motoresBkp.Add(new Motor("1005", "G19A	", "33110-M-1582	", "Ventilador de circ de ar T25-8                            "));
            motoresBkp.Add(new Motor("1005", "G19B	", "33110-M-1583	", "Ventilador de circ de ar T25-9                            "));
            motoresBkp.Add(new Motor("1005", "G19C	", "33110-M-1584	", "Ventilador de circ de ar T25-10                           "));
            motoresBkp.Add(new Motor("1005", "G19D	", "33110-M-1587	", "Ventilador de circ de ar T26-3                            "));
            motoresBkp.Add(new Motor("1005", "G19E	", "33110-M-1588	", "Ventilador de circ de ar T26-4                            "));
            motoresBkp.Add(new Motor("1005", "G19F	", "33110-M-1596	", "Ventilador de circ de ar T27-2                            "));
            motoresBkp.Add(new Motor("1005", "G19G	", "33110-M-1615	", "Ventilador de circ de ar T29-1                            "));
            motoresBkp.Add(new Motor("1005", "G19H	", "33110-M-1616	", "Ventilador de circ de ar T29-2                            "));
            motoresBkp.Add(new Motor("1005", "G20A	", "33110-M-1589	", "Ventilador de circ de ar T26-5                            "));
            motoresBkp.Add(new Motor("1005", "G20B	", "33110-M-1590	", "Ventilador de circ de ar T26-6                            "));
            motoresBkp.Add(new Motor("1005", "G20C	", "33110-M-1591	", "Ventilador de circ de ar T26-7                            "));
            motoresBkp.Add(new Motor("1005", "G20D	", "33110-M-1592	", "Ventilador de circ de ar T26-8                            "));
            motoresBkp.Add(new Motor("1005", "G20E	", "33110-M-1593	", "Ventilador de circ de ar T26-9                            "));
            motoresBkp.Add(new Motor("1005", "G20F	", "33110-M-1594	", "Ventilador de circ de ar T26-10                           "));
            motoresBkp.Add(new Motor("1005", "G20G	", "33110-M-1597	", "Ventilador de circ de ar T27-3                            "));
            motoresBkp.Add(new Motor("1005", "G20H	", "33110-M-1605	", "Ventilador de circ de ar T28-1                            "));
            motoresBkp.Add(new Motor("1005", "G20I	", "33110-M-1606	", "Ventilador de circ de ar T28-2                            "));
            motoresBkp.Add(new Motor("1005", "G21A	", "33110-M-1598	", "Ventilador de circ de ar T27-4                            "));
            motoresBkp.Add(new Motor("1005", "G21B	", "33110-M-1599	", "Ventilador de circ de ar T27-5                            "));
            motoresBkp.Add(new Motor("1005", "G21C	", "33110-M-1600	", "Ventilador de circ de ar T27-6                            "));
            motoresBkp.Add(new Motor("1005", "G21D	", "33110-M-1601	", "Ventilador de circ de ar T27-7                            "));
            motoresBkp.Add(new Motor("1005", "G21E	", "33110-M-1602	", "Ventilador de circ de ar T27-8                            "));
            motoresBkp.Add(new Motor("1005", "G21F	", "33110-M-1603	", "Ventilador de circ de ar T27-9                            "));
            motoresBkp.Add(new Motor("1005", "G21G	", "33110-M-1604	", "Ventilador de circ de ar T27-10                           "));
            motoresBkp.Add(new Motor("1005", "G21H	", "33110-M-1607	", "Ventilador de circ de ar T28-3                            "));
            motoresBkp.Add(new Motor("1005", "G21I	", "33110-M-1608	", "Ventilador de circ de ar T28-4                            "));
            motoresBkp.Add(new Motor("1005", "G21J	", "33110-M-1609	", "Ventilador de circ de ar T28-5                            "));
            motoresBkp.Add(new Motor("1005", "G21K	", "33110-M-1610	", "Ventilador de circ de ar T28-6                            "));
            motoresBkp.Add(new Motor("1005", "G22A	", "33110-M-1611	", "Ventilador de circ de ar T28-7                            "));
            motoresBkp.Add(new Motor("1005", "G22B	", "33110-M-1612	", "Ventilador de circ de ar T28-8                            "));
            motoresBkp.Add(new Motor("1005", "G22C	", "33110-M-1613	", "Ventilador de circ de ar T28-9                            "));
            motoresBkp.Add(new Motor("1005", "G22D	", "33110-M-1614	", "Ventilador de circ de ar T28-10                           "));
            motoresBkp.Add(new Motor("1005", "G22E	", "33110-M-1617	", "Ventilador de circ de ar T29-3                            "));
            motoresBkp.Add(new Motor("1005", "G22F	", "33110-M-1618	", "Ventilador de circ de ar T29-4                            "));
            motoresBkp.Add(new Motor("1005", "G22G	", "33110-M-1619	", "Ventilador de circ de ar T29-5                            "));
            motoresBkp.Add(new Motor("1005", "G22H	", "33110-M-1620	", "Ventilador de circ de ar T29-6                            "));
            motoresBkp.Add(new Motor("1005", "G22I	", "33110-M-1621	", "Ventilador de circ de ar T29-7                            "));
            motoresBkp.Add(new Motor("1005", "G22J	", "33110-M-1622	", "Ventilador de circ de ar T29-8                            "));
            motoresBkp.Add(new Motor("1005", "G22K	", "33110-M-1623	", "Ventilador de circ de ar T29-9                            "));
            motoresBkp.Add(new Motor("1005", "G23A	", "33110-M-1624	", "Ventilador de circ de ar T29-10                           "));
            motoresBkp.Add(new Motor("1005", "G23D	", "33110-M-1976	", "Elemento de aquecimento do facão                          "));
            motoresBkp.Add(new Motor("1005", "G23E	", "33110-M-1982	", "Bomba hidráulica do layboy cortadeira                     "));
            motoresBkp.Add(new Motor("1005", "G23F	", "33110-M-1980	", "Mesa de recebimento de fardos                             "));
            motoresBkp.Add(new Motor("1005", "G24B	", "33110-M-1977	", "Elemento de aquecimento do facão                          "));
            motoresBkp.Add(new Motor("1005", "G24C	", "33110-M-1978	", "Batedor                                                   "));
            motoresBkp.Add(new Motor("1005", "G24E	", "33110-M-1981	", "Transportador de quebra                                   "));
            motoresBkp.Add(new Motor("1005", "G24F	", "33110-M-1990	", "Sopradores de vácuo lado controle                         "));
            motoresBkp.Add(new Motor("1005", "G25A	", "33110-M-1983	", "Apalpador LC-LC                                           "));
            motoresBkp.Add(new Motor("1005", "G25B	", "33110-M-1984	", "Apalpador LA-LA                                           "));
            motoresBkp.Add(new Motor("1005", "G25G	", "33110-M-3009	", "Pichasso da ponta                                         "));
            motoresBkp.Add(new Motor("1005", "G26F	", "33110-M-1991	", "Sopradores de vácuo lado acionamento                      "));
            motoresBkp.Add(new Motor("1006", "G3A	", "33110-M-1326	", "Ventilador de circ de ar torre final parte úmida 1            "));
            motoresBkp.Add(new Motor("1006", "G4A	", "33110-M-1327	", "Ventilador de circ de ar torre final parte úmida 2            "));
            motoresBkp.Add(new Motor("1006", "G5A	", "33110-M-1328	", "Ventilador de circ de ar torre final parte úmida 3            "));
            motoresBkp.Add(new Motor("1006", "G6A	", "33110-M-1329	", "Ventilador de circ de ar torre final parte úmida 4            "));
            motoresBkp.Add(new Motor("1006", "C7A	", "33110-M-1330	", "Ventilador de circ de ar torre final parte úmida 5            "));
            motoresBkp.Add(new Motor("1006", "G8A	", "33110-M-1331	", "Ventilador de circ de ar torre final parte úmida 6            "));
            motoresBkp.Add(new Motor("1006", "G9A	", "33110-M-1332	", "Ventilador de circ de ar torre final parte úmida 7            "));
            motoresBkp.Add(new Motor("1006", "G10A	", "33110-M-1333	", "Ventilador de circ de ar torre final parte úmida 8        "));
            motoresBkp.Add(new Motor("1006", "G11A	", "33110-M-1334	", "Ventilador de circ de ar torre final parte úmida 9        "));
            motoresBkp.Add(new Motor("1006", "G12A	", "33110-M-1627	", "Ventilador de circ de ar lado seco torre final 3          "));
            motoresBkp.Add(new Motor("1006", "G13A	", "33110-M-1628	", "Ventilador de circ de ar lado seco torre final 4          "));
            motoresBkp.Add(new Motor("1006", "G14A	", "33110-M-1629	", "Ventilador de circ de ar lado seco torre final 5          "));
            motoresBkp.Add(new Motor("1006", "G15A	", "33110-M-1630	", "Ventilador de circ de ar lado seco torre final 6          "));
            motoresBkp.Add(new Motor("1006", "G16A	", "33110-M-1631	", "Ventilador de circ de ar lado seco torre final 7          "));
            motoresBkp.Add(new Motor("1006", "G17A	", "33110-M-1632	", "Ventilador de circ de ar lado seco torre final 8          "));
            motoresBkp.Add(new Motor("1006", "G18A	", "33110-M-1633	", "Ventilador de circ de ar lado seco torre final 9          "));
            motoresBkp.Add(new Motor("1006", "G19A	", "33110-M-1636	", "Exaustor de ar 3                                          "));
            motoresBkp.Add(new Motor("1006", "G20A	", "33110-M-1640	", "Ventilador de insulfamento de ar 3                        "));
            motoresBkp.Add(new Motor("1006", "G23A	", "33110-M-1473	", "Ventilador de circ de ar T14-9                            "));
            motoresBkp.Add(new Motor("1006", "G23B	", "33110-M-1474	", "Ventilador de circ de ar T14-10                           "));
            motoresBkp.Add(new Motor("1006", "G23C	", "33110-M-1475	", "Ventilador de circ de ar T15-1                            "));
            motoresBkp.Add(new Motor("1006", "G23D	", "33110-M-1325	", "Ventilador de exaustão de ar limpeza da tela              "));
            motoresBkp.Add(new Motor("1006", "G23E	", "33110-M-1324	", "Ventilador de exaustão de ar 2 seção da tela              "));
            motoresBkp.Add(new Motor("1006", "G24A	", "33110-M-1487	", "Ventilador de circ de ar T16-3                            "));
            motoresBkp.Add(new Motor("1006", "G24B	", "33110-M-1477	", "Ventilador de circ de ar T15-3                            "));
            motoresBkp.Add(new Motor("1006", "G24C	", "33110-M-1478	", "Ventilador de circ de ar T15-4                            "));
            motoresBkp.Add(new Motor("1006", "G24D	", "33110-M-1479	", "Ventilador de circ de ar T15-5                            "));
            motoresBkp.Add(new Motor("1006", "G24E	", "33110-M-1480	", "Ventilador de circ de ar T15-6                            "));
            motoresBkp.Add(new Motor("1006", "G24F	", "33110-M-1481	", "Ventilador de circ de ar T15-7                            "));
            motoresBkp.Add(new Motor("1006", "G24G	", "33110-M-1482	", "Ventilador de circ de ar T15-8                            "));
            motoresBkp.Add(new Motor("1006", "G24H	", "33110-M-1483	", "Ventilador de circ de ar T15-9                            "));
            motoresBkp.Add(new Motor("1006", "G24I	", "33110-M-1484	", "Ventilador de circ de ar T15-10                           "));
            motoresBkp.Add(new Motor("1006", "G24J	", "33110-M-1476	", "Ventilador de circ de ar T15-2                            "));
            motoresBkp.Add(new Motor("1006", "G25A	", "33110-M-1488	", "Ventilador de circ de ar T16-4                            "));
            motoresBkp.Add(new Motor("1006", "G25B	", "33110-M-1489	", "Ventilador de circ de ar T16-5                            "));
            motoresBkp.Add(new Motor("1006", "G25C	", "33110-M-1490	", "Ventilador de circ de ar T16-6                            "));
            motoresBkp.Add(new Motor("1006", "G25D	", "33110-M-1491	", "Ventilador de circ de ar T16-7                            "));
            motoresBkp.Add(new Motor("1006", "G25E	", "33110-M-1492	", "Ventilador de circ de ar T16-8                            "));
            motoresBkp.Add(new Motor("1006", "G25F	", "33110-M-1493	", "Ventilador de circ de ar T16-9                            "));
            motoresBkp.Add(new Motor("1006", "G25G	", "33110-M-1494	", "Ventilador de circ de ar T16-10                           "));
            motoresBkp.Add(new Motor("1006", "G25H	", "33110-M-1485	", "Ventilador de circ de ar T16-1                            "));
            motoresBkp.Add(new Motor("1006", "G25I	", "33110-M-1486	", "Ventilador de circ de ar T16-2                            "));
            motoresBkp.Add(new Motor("1006", "G26A	", "33110-M-1497	", "Ventilador de circ de ar T17-3                            "));
            motoresBkp.Add(new Motor("1006", "G26B	", "33110-M-1498	", "Ventilador de circ de ar T17-4                            "));
            motoresBkp.Add(new Motor("1006", "G26C	", "33110-M-1499	", "Ventilador de circ de ar T17-5                            "));
            motoresBkp.Add(new Motor("1006", "G26D	", "33110-M-1500	", "Ventilador de circ de ar T17-6                            "));
            motoresBkp.Add(new Motor("1006", "G26E	", "33110-M-1501	", "Ventilador de circ de ar T17-7                            "));
            motoresBkp.Add(new Motor("1006", "G26F	", "33110-M-1502	", "Ventilador de circ de ar T17-8                            "));
            motoresBkp.Add(new Motor("1006", "G26G	", "33110-M-1503	", "Ventilador de circ de ar T17-9                            "));
            motoresBkp.Add(new Motor("1006", "G26H	", "33110-M-1495	", "Ventilador de circ de ar T17-1                            "));
            motoresBkp.Add(new Motor("1006", "G26I	", "33110-M-1496	", "Ventilador de circ de ar T17-2                            "));
            motoresBkp.Add(new Motor("1005", "G29G	", "33110-M-1979	", "Mesa de recebimento de fardos                             "));
            motoresBkp.Add(new Motor("1006", "G27A	", "33110-M-1504	", "Ventilador de circ de ar T17-10                           "));
            motoresBkp.Add(new Motor("1006", "G27B	", "33110-M-1507	", "Ventilador de circ de ar T18-3                            "));
            motoresBkp.Add(new Motor("1006", "G27C	", "33110-M-1508	", "Ventilador de circ de ar T18-4                            "));
            motoresBkp.Add(new Motor("1006", "G27D	", "33110-M-1509	", "Ventilador de circ de ar T18-5                            "));
            motoresBkp.Add(new Motor("1006", "G27E	", "33110-M-1510	", "Ventilador de circ de ar T18-6                            "));
            motoresBkp.Add(new Motor("1006", "G27F	", "33110-M-1511	", "Ventilador de circ de ar T18-7                            "));
            motoresBkp.Add(new Motor("1006", "G27G	", "33110-M-1512	", "Ventilador de circ de ar T18-8                            "));
            motoresBkp.Add(new Motor("1006", "G27H	", "33110-M-1505	", "Ventilador de circ de ar T18-1                            "));
            motoresBkp.Add(new Motor("1006", "G27I	", "33110-M-1506	", "Ventilador de circ de ar T18-2                            "));
            motoresBkp.Add(new Motor("1006", "C28A	", "33110-M-1513	", "Ventilador de circ de ar T18-9                            "));
            motoresBkp.Add(new Motor("1006", "C28B	", "33110-M-1514	", "Ventilador de circ de ar T18-10                           "));
            motoresBkp.Add(new Motor("1006", "C28C	", "33110-M-1517	", "Ventilador de circ de ar T19-3                            "));
            motoresBkp.Add(new Motor("1006", "C28D	", "33110-M-1518	", "Ventilador de circ de ar T19-4                            "));
            motoresBkp.Add(new Motor("1006", "C28E	", "33110-M-1519	", "Ventilador de circ de ar T19-5                            "));
            motoresBkp.Add(new Motor("1006", "C28F	", "33110-M-1520	", "Ventilador de circ de ar T19-6                            "));
            motoresBkp.Add(new Motor("1006", "C28G	", "33110-M-1521	", "Ventilador de circ de ar T19-7                            "));
            motoresBkp.Add(new Motor("1006", "C28H	", "33110-M-1515	", "Ventilador de circ de ar T19-1                            "));
            motoresBkp.Add(new Motor("1006", "C28I	", "33110-M-1516	", "Ventilador de circ de ar T19-2                            "));
            motoresBkp.Add(new Motor("1006", "C29A	", "33110-M-1522	", "Ventilador de circ de ar T19-8                            "));
            motoresBkp.Add(new Motor("1006", "C29B	", "33110-M-1523	", "Ventilador de circ de ar T19-9                            "));
            motoresBkp.Add(new Motor("1006", "C29C	", "33110-M-1524	", "Ventilador de circ de ar T19-10                           "));
            motoresBkp.Add(new Motor("1006", "C29D	", "33110-M-1526	", "Ventilador de circ de ar T20-3                            "));
            motoresBkp.Add(new Motor("1006", "C29E	", "33110-M-1528	", "Ventilador de circ de ar T20-4                            "));
            motoresBkp.Add(new Motor("1006", "C29F	", "33110-M-1529	", "Ventilador de circ de ar T20-5                            "));
            motoresBkp.Add(new Motor("1006", "C29G	", "33110-M-1530	", "Ventilador de circ de ar T20-6                            "));
            motoresBkp.Add(new Motor("1006", "C29H	", "33110-M-1525	", "Ventilador de circ de ar T20-1                            "));
            motoresBkp.Add(new Motor("1006", "C29I	", "33110-M-1526	", "Ventilador de circ de ar T20-2                            "));
            motoresBkp.Add(new Motor("1006", "C30A	", "33110-M-1531	", "Ventilador de circ de ar T20-7                            "));
            motoresBkp.Add(new Motor("1006", "C30B	", "33110-M-1532	", "Ventilador de circ de ar T20-8                            "));
            motoresBkp.Add(new Motor("1006", "C30C	", "33110-M-1533	", "Ventilador de circ de ar T20-9                            "));
            motoresBkp.Add(new Motor("1006", "C30D	", "33110-M-1534	", "Ventilador de circ de ar T20-10                           "));
            motoresBkp.Add(new Motor("1006", "C30E	", "33110-M-1537	", "Ventilador de circ de ar T21-3                            "));
            motoresBkp.Add(new Motor("1006", "C30F	", "33110-M-1538	", "Ventilador de circ de ar T21-4                            "));
            motoresBkp.Add(new Motor("1006", "C30G	", "33110-M-1539	", "Ventilador de circ de ar T21-5                            "));
            motoresBkp.Add(new Motor("1006", "C30H	", "33110-M-1535	", "Ventilador de circ de ar T21-1                            "));
            motoresBkp.Add(new Motor("1006", "C30I	", "33110-M-1536	", "Ventilador de circ de ar T21-2                            "));
            motoresBkp.Add(new Motor("1006", "C31A	", "33110-M-1540	", "Ventilador de circ de ar T21-6                            "));
            motoresBkp.Add(new Motor("1006", "C31B	", "33110-M-1541	", "Ventilador de circ de ar T21-7                            "));
            motoresBkp.Add(new Motor("1006", "C31C	", "33110-M-1542	", "Ventilador de circ de ar T21-8                            "));
            motoresBkp.Add(new Motor("1006", "C31D	", "33110-M-1543	", "Ventilador de circ de ar T21-9                            "));
            motoresBkp.Add(new Motor("1006", "C31E	", "33110-M-1544	", "Ventilador de circ de ar T21-10                           "));
            motoresBkp.Add(new Motor("1006", "C31F	", "33110-M-1547	", "Ventilador de circ de ar T22-3                            "));
            motoresBkp.Add(new Motor("1006", "C31G	", "33110-M-1548	", "Ventilador de circ de ar T22-4                            "));
            motoresBkp.Add(new Motor("1006", "C31H	", "33110-M-1545	", "Ventilador de circ de ar T22-1                            "));
            motoresBkp.Add(new Motor("1006", "C31I	", "33110-M-1546	", "Ventilador de circ de ar T22-2                            "));
            motoresBkp.Add(new Motor("1006", "C32B	", "33110-M-1551	", "Ventilador de circ de ar T22-7                            "));
            motoresBkp.Add(new Motor("1006", "C32C	", "33110-M-1552	", "Ventilador de circ de ar T22-8                            "));
            motoresBkp.Add(new Motor("1006", "C32D	", "33110-M-1553	", "Ventilador de circ de ar T22-9                            "));
            motoresBkp.Add(new Motor("1006", "C32E	", "33110-M-1554	", "Ventilador de circ de ar T22-10                           "));
            motoresBkp.Add(new Motor("1007", "G3A	", "33110-M-1635	", "Exaustor de ar 2                                              "));
            motoresBkp.Add(new Motor("1007", "G4A	", "33110-M-1639	", "Ventilador de insuflamento de ar 2                            "));
            motoresBkp.Add(new Motor("1007", "G5A	", "33110-M-1351	", "Ventilador de circ de ar T2-7                                 "));
            motoresBkp.Add(new Motor("1007", "G5B	", "33110-M-1352	", "Ventilador de circ de ar T2-8                                 "));
            motoresBkp.Add(new Motor("1007", "G5C	", "33110-M-1353	", "Ventilador de circ de ar T2-9                                 "));
            motoresBkp.Add(new Motor("1007", "G5D	", "33110-M-1354	", "Ventilador de circ de ar T2-10                                "));
            motoresBkp.Add(new Motor("1007", "G5E	", "33110-M-1357	", "Ventilador de circ de ar T3-3                                 "));
            motoresBkp.Add(new Motor("1007", "G5F	", "33110-M-1358	", "Ventilador de circ de ar T3-4                                 "));
            motoresBkp.Add(new Motor("1007", "G5G	", "33110-M-1359	", "Ventilador de circ de ar T3-5                                 "));
            motoresBkp.Add(new Motor("1007", "G5H	", "33110-M-1355	", "Ventilador de circ de ar T3-1                                 "));
            motoresBkp.Add(new Motor("1007", "G5I	", "33110-M-1356	", "Ventilador de circ de ar T3-2                                 "));
            motoresBkp.Add(new Motor("1007", "G6A	", "33110-M-1360	", "Ventilador de circ de ar T3-6                                 "));
            motoresBkp.Add(new Motor("1007", "G6B	", "33110-M-1361	", "Ventilador de circ de ar T3-7                                 "));
            motoresBkp.Add(new Motor("1007", "G6C	", "33110-M-1362	", "Ventilador de circ de ar T3-8                                 "));
            motoresBkp.Add(new Motor("1007", "G6D	", "33110-M-1363	", "Ventilador de circ de ar T3-9                                 "));
            motoresBkp.Add(new Motor("1007", "G6E	", "33110-M-1364	", "Ventilador de circ de ar T3-10                                "));
            motoresBkp.Add(new Motor("1007", "G6F	", "33110-M-1367	", "Ventilador de circ de ar T4-3                                 "));
            motoresBkp.Add(new Motor("1007", "G6G	", "33110-M-1368	", "Ventilador de circ de ar T4-4                                 "));
            motoresBkp.Add(new Motor("1007", "G6H	", "33110-M-1365	", "Ventilador de circ de ar T4-1                                 "));
            motoresBkp.Add(new Motor("1007", "G6I	", "33110-M-1366	", "Ventilador de circ de ar T4-2                                 "));
            motoresBkp.Add(new Motor("1007", "G7A	", "33110-M-1369	", "Ventilador de circ de ar T4-5                                 "));
            motoresBkp.Add(new Motor("1007", "G7B	", "33110-M-1370	", "Ventilador de circ de ar T4-6                                 "));
            motoresBkp.Add(new Motor("1007", "G7C	", "33110-M-1371	", "Ventilador de circ de ar T4-7                                 "));
            motoresBkp.Add(new Motor("1007", "G7D	", "33110-M-1372	", "Ventilador de circ de ar T4-8                                 "));
            motoresBkp.Add(new Motor("1007", "G7E	", "33110-M-1373	", "Ventilador de circ de ar T4-9                                 "));
            motoresBkp.Add(new Motor("1007", "G7F	", "33110-M-1374	", "Ventilador de circ de ar T4-10                                "));
            motoresBkp.Add(new Motor("1007", "G7G	", "33110-M-1377	", "Ventilador de circ de ar T5-3                                 "));
            motoresBkp.Add(new Motor("1007", "G7H	", "33110-M-1375	", "Ventilador de circ de ar T5-1                                 "));
            motoresBkp.Add(new Motor("1007", "G7I	", "33110-M-1376	", "Ventilador de circ de ar T5-2                                 "));
            motoresBkp.Add(new Motor("1007", "G8A	", "33110-M-1378	", "Ventilador de circ de ar T5-4                                 "));
            motoresBkp.Add(new Motor("1007", "G8B	", "33110-M-1379	", "Ventilador de circ de ar T5-5                                 "));
            motoresBkp.Add(new Motor("1007", "G8C	", "33110-M-1380	", "Ventilador de circ de ar T5-6                                 "));
            motoresBkp.Add(new Motor("1007", "G8D	", "33110-M-1381	", "Ventilador de circ de ar T5-7                                 "));
            motoresBkp.Add(new Motor("1007", "G8E	", "33110-M-1382	", "Ventilador de circ de ar T5-8                                 "));
            motoresBkp.Add(new Motor("1007", "G8F	", "33110-M-1383	", "Ventilador de circ de ar T5-9                                 "));
            motoresBkp.Add(new Motor("1007", "G8G	", "33110-M-1384	", "Ventilador de circ de ar T5-10                                "));
            motoresBkp.Add(new Motor("1007", "G8H	", "33110-M-1385	", "Ventilador de circ de ar T6-1                                 "));
            motoresBkp.Add(new Motor("1007", "G8I	", "33110-M-1386	", "Ventilador de circ de ar T6-2                                 "));
            motoresBkp.Add(new Motor("1007", "G9A	", "33110-M-1387	", "Ventilador de circ de ar T6-3                                 "));
            motoresBkp.Add(new Motor("1007", "G9B	", "33110-M-1388	", "Ventilador de circ de ar T6-4                                 "));
            motoresBkp.Add(new Motor("1007", "G9C	", "33110-M-1389	", "Ventilador de circ de ar T6-5                                 "));
            motoresBkp.Add(new Motor("1007", "G9D	", "33110-M-1390	", "Ventilador de circ de ar T6-6                                 "));
            motoresBkp.Add(new Motor("1007", "G9E	", "33110-M-1391	", "Ventilador de circ de ar T6-7                                 "));
            motoresBkp.Add(new Motor("1007", "G9F	", "33110-M-1392	", "Ventilador de circ de ar T6-8                                 "));
            motoresBkp.Add(new Motor("1007", "G9G	", "33110-M-1393	", "Ventilador de circ de ar T6-9                                 "));
            motoresBkp.Add(new Motor("1007", "G9H	", "33110-M-1395	", "Ventilador de circ de ar T7-1                                 "));
            motoresBkp.Add(new Motor("1007", "G9I	", "33110-M-1396	", "Ventilador de circ de ar T7-2                                 "));
            motoresBkp.Add(new Motor("1007", "G10A	", "33110-M-1394	", "Ventilador de circ de ar T6-10                            "));
            motoresBkp.Add(new Motor("1007", "G10B	", "33110-M-1397	", "Ventilador de circ de ar T7-3                             "));
            motoresBkp.Add(new Motor("1007", "G10C	", "33110-M-1398	", "Ventilador de circ de ar T7-4                             "));
            motoresBkp.Add(new Motor("1007", "G10D	", "33110-M-1399	", "Ventilador de circ de ar T7-5                             "));
            motoresBkp.Add(new Motor("1007", "G10E	", "33110-M-1400	", "Ventilador de circ de ar T7-6                             "));
            motoresBkp.Add(new Motor("1007", "G10F	", "33110-M-1401	", "Ventilador de circ de ar T7-7                             "));
            motoresBkp.Add(new Motor("1007", "G10G	", "33110-M-1402	", "Ventilador de circ de ar T7-8                             "));
            motoresBkp.Add(new Motor("1007", "G10H	", "33110-M-1405	", "Ventilador de circ de ar T8-1                             "));
            motoresBkp.Add(new Motor("1007", "G10I	", "33110-M-1406	", "Ventilador de circ de ar T8-2                             "));
            motoresBkp.Add(new Motor("1007", "G11A	", "33110-M-1403	", "Ventilador de circ de ar T7-9                             "));
            motoresBkp.Add(new Motor("1007", "G11B	", "33110-M-1404	", "Ventilador de circ de ar T7-10                            "));
            motoresBkp.Add(new Motor("1007", "G11C	", "33110-M-1407	", "Ventilador de circ de ar T8-3                             "));
            motoresBkp.Add(new Motor("1007", "G11D	", "33110-M-1408	", "Ventilador de circ de ar T8-4                             "));
            motoresBkp.Add(new Motor("1007", "G11E	", "33110-M-1409	", "Ventilador de circ de ar T8-5                             "));
            motoresBkp.Add(new Motor("1007", "G11F	", "33110-M-1410	", "Ventilador de circ de ar T8-6                             "));
            motoresBkp.Add(new Motor("1007", "G11G	", "33110-M-1411	", "Ventilador de circ de ar T8-7                             "));
            motoresBkp.Add(new Motor("1007", "G11H	", "33110-M-1415	", "Ventilador de circ de ar T9-1                             "));
            motoresBkp.Add(new Motor("1007", "G11I	", "33110-M-1416	", "Ventilador de circ de ar T9-2                             "));
            motoresBkp.Add(new Motor("1007", "G12A	", "33110-M-1412	", "Ventilador de circ de ar T8-8                             "));
            motoresBkp.Add(new Motor("1007", "G12B	", "33110-M-1413	", "Ventilador de circ de ar T8-9                             "));
            motoresBkp.Add(new Motor("1007", "G12C	", "33110-M-1414	", "Ventilador de circ de ar T8-10                            "));
            motoresBkp.Add(new Motor("1007", "G12D	", "33110-M-1417	", "Ventilador de circ de ar T9-3                             "));
            motoresBkp.Add(new Motor("1007", "G12E	", "33110-M-1418	", "Ventilador de circ de ar T9-4                             "));
            motoresBkp.Add(new Motor("1007", "G12F	", "33110-M-1419	", "Ventilador de circ de ar T9-5                             "));
            motoresBkp.Add(new Motor("1007", "G12G	", "33110-M-1420	", "Ventilador de circ de ar T9-6                             "));
            motoresBkp.Add(new Motor("1007", "G12H	", "33110-M-1421	", "Ventilador de circ de ar T9-7                             "));
            motoresBkp.Add(new Motor("1007", "G12I	", "33110-M-1422	", "Ventilador de circ de ar T9-8                             "));
            motoresBkp.Add(new Motor("1007", "G12J	", "33110-M-1423	", "Ventilador de circ de ar T9-9                             "));
            motoresBkp.Add(new Motor("1007", "G12K	", "33110-M-1424	", "Ventilador de circ de ar T9-10                            "));
            motoresBkp.Add(new Motor("1007", "G13A	", "33110-M-1427	", "Ventilador de circ de ar T10-3                            "));
            motoresBkp.Add(new Motor("1007", "G13B	", "33110-M-1428	", "Ventilador de circ de ar T10-4                            "));
            motoresBkp.Add(new Motor("1007", "G13C	", "33110-M-1429	", "Ventilador de circ de ar T10-5                            "));
            motoresBkp.Add(new Motor("1007", "G13D	", "33110-M-1430	", "Ventilador de circ de ar T10-6                            "));
            motoresBkp.Add(new Motor("1007", "G13E	", "33110-M-1431	", "Ventilador de circ de ar T10-7                            "));
            motoresBkp.Add(new Motor("1007", "G13F	", "33110-M-1432	", "Ventilador de circ de ar T10-8                            "));
            motoresBkp.Add(new Motor("1007", "G13G	", "33110-M-1433	", "Ventilador de circ de ar T10-9                            "));
            motoresBkp.Add(new Motor("1007", "G13H	", "33110-M-1425	", "Ventilador de circ de ar T10-1                            "));
            motoresBkp.Add(new Motor("1007", "G13I	", "33110-M-1426	", "Ventilador de circ de ar T10-2                            "));
            motoresBkp.Add(new Motor("1007", "G14A	", "33110-M-1434	", "Ventilador de circ de ar T10-10                           "));
            motoresBkp.Add(new Motor("1007", "G14B	", "33110-M-1437	", "Ventilador de circ de ar T11-3                            "));
            motoresBkp.Add(new Motor("1007", "G14C	", "33110-M-1438	", "Ventilador de circ de ar T11-4                            "));
            motoresBkp.Add(new Motor("1007", "G14D	", "33110-M-1439	", "Ventilador de circ de ar T11-5                            "));
            motoresBkp.Add(new Motor("1007", "G14E	", "33110-M-1440	", "Ventilador de circ de ar T11-6                            "));
            motoresBkp.Add(new Motor("1007", "G14F	", "33110-M-1441	", "Ventilador de circ de ar T11-7                            "));
            motoresBkp.Add(new Motor("1007", "G14G	", "33110-M-1442	", "Ventilador de circ de ar T11-8                            "));
            motoresBkp.Add(new Motor("1007", "G14H	", "33110-M-1435	", "Ventilador de circ de ar T11-1                            "));
            motoresBkp.Add(new Motor("1007", "G14I	", "33110-M-1436	", "Ventilador de circ de ar T11-2                            "));
            motoresBkp.Add(new Motor("1007", "G15A	", "33110-M-1443	", "Ventilador de circ de ar T11-9                            "));
            motoresBkp.Add(new Motor("1007", "G15B	", "33110-M-1444	", "Ventilador de circ de ar T11-10                           "));
            motoresBkp.Add(new Motor("1007", "G15C	", "33110-M-1447	", "Ventilador de circ de ar T12-3                            "));
            motoresBkp.Add(new Motor("1007", "G15D	", "33110-M-1448	", "Ventilador de circ de ar T12-4                            "));
            motoresBkp.Add(new Motor("1007", "G15E	", "33110-M-1449	", "Ventilador de circ de ar T12-5                            "));
            motoresBkp.Add(new Motor("1007", "G15F	", "33110-M-1450	", "Ventilador de circ de ar T12-6                            "));
            motoresBkp.Add(new Motor("1007", "G15G	", "33110-M-1451	", "Ventilador de circ de ar T12-7                            "));
            motoresBkp.Add(new Motor("1007", "G15H	", "33110-M-1445	", "Ventilador de circ de ar T12-1                            "));
            motoresBkp.Add(new Motor("1007", "G15I	", "33110-M-1446	", "Ventilador de circ de ar T12-2                            "));
            motoresBkp.Add(new Motor("1007", "G16A	", "33110-M-1452	", "Ventilador de circ de ar T12-8                            "));
            motoresBkp.Add(new Motor("1007", "G16B	", "33110-M-1453	", "Ventilador de circ de ar T12-9                            "));
            motoresBkp.Add(new Motor("1007", "G16C	", "33110-M-1454	", "Ventilador de circ de ar T12-10                           "));
            motoresBkp.Add(new Motor("1007", "G16D	", "33110-M-1457	", "Ventilador de circ de ar T13-3                            "));
            motoresBkp.Add(new Motor("1007", "G16E	", "33110-M-1458	", "Ventilador de circ de ar T13-4                            "));
            motoresBkp.Add(new Motor("1007", "G16F	", "33110-M-1459	", "Ventilador de circ de ar T13-5                            "));
            motoresBkp.Add(new Motor("1007", "G16G	", "33110-M-1460	", "Ventilador de circ de ar T13-6                            "));
            motoresBkp.Add(new Motor("1007", "G16H	", "33110-M-1455	", "Ventilador de circ de ar T13-1                            "));
            motoresBkp.Add(new Motor("1007", "G16I	", "33110-M-1456	", "Ventilador de circ de ar T13-2                            "));
            motoresBkp.Add(new Motor("1007", "G17A	", "33110-M-1461	", "Ventilador de circ de ar T13-7                            "));
            motoresBkp.Add(new Motor("1007", "G17B	", "33110-M-1462	", "Ventilador de circ de ar T13-8                            "));
            motoresBkp.Add(new Motor("1007", "G17C	", "33110-M-1463	", "Ventilador de circ de ar T13-9                            "));
            motoresBkp.Add(new Motor("1007", "G17D	", "33110-M-1464	", "Ventilador de circ de ar T13-10                           "));
            motoresBkp.Add(new Motor("1007", "G17E	", "33110-M-1467	", "Ventilador de circ de ar T14-3                            "));
            motoresBkp.Add(new Motor("1007", "G17F	", "33110-M-1468	", "Ventilador de circ de ar T14-4                            "));
            motoresBkp.Add(new Motor("1007", "G17G	", "33110-M-1469	", "Ventilador de circ de ar T14-5                            "));
            motoresBkp.Add(new Motor("1007", "G17H	", "33110-M-1465	", "Ventilador de circ de ar T14-1                            "));
            motoresBkp.Add(new Motor("1007", "G17I	", "33110-M-1466	", "Ventilador de circ de ar T14-2                            "));
            motoresBkp.Add(new Motor("1007", "G18A	", "33110-M-1470	", "Ventilador de circ de ar T14-6                            "));
            motoresBkp.Add(new Motor("1007", "G18B	", "33110-M-1471	", "Ventilador de circ de ar T14-7                            "));
            motoresBkp.Add(new Motor("1007", "G18C	", "33110-M-1472	", "Ventilador de circ de ar T14-8                            "));
            motoresBkp.Add(new Motor("1009", "G4A	", "33110-M-1634	", "Exaustor de ar 1                                              "));
            motoresBkp.Add(new Motor("1009", "G5A	", "33110-M-1638	", "Ventilador de insulfamento de ar 1                            "));
            motoresBkp.Add(new Motor("1009", "G6A	", "33110-M-1337	", "Ventilador de circ de ar T1-3                                 "));
            motoresBkp.Add(new Motor("1009", "G6D	", "33110-M-1335	", "Ventilador de circ de ar T1-1                                 "));
            motoresBkp.Add(new Motor("1009", "G6E	", "33110-M-1336	", "Ventilador de circ de ar T1-2                                 "));
            motoresBkp.Add(new Motor("1009", "G6F	", "33110-M-1323	", "Ventilador de exaustão de ar 1 - seção da tela                "));
            motoresBkp.Add(new Motor("1009", "G7A	", "33110-M-1338	", "Ventilador de circ de ar T1-4                                 "));
            motoresBkp.Add(new Motor("1009", "G7B	", "33110-M-1339	", "Ventilador de circ de ar T1-5                                 "));
            motoresBkp.Add(new Motor("1009", "G7C	", "33110-M-1340	", "Ventilador de circ de ar T1-6                                 "));
            motoresBkp.Add(new Motor("1009", "G7D	", "33110-M-1341	", "Ventilador de cird de ar T1-7                                 "));
            motoresBkp.Add(new Motor("1009", "G7E	", "33110-M-1342	", "Ventilador de circ de ar T1-8                                 "));
            motoresBkp.Add(new Motor("1009", "G7F	", "33110-M-1343	", "Ventilador de circ de ar T1-9                                 "));
            motoresBkp.Add(new Motor("1009", "G7G	", "33110-M-1344	", "Ventilador de circ de ar T1-10                                "));
            motoresBkp.Add(new Motor("1009", "G7H	", "33110-M-1345	", "Ventilador de circ de ar T2-1                                 "));
            motoresBkp.Add(new Motor("1009", "G7I	", "33110-M-1346	", "Ventilador de circ de ar T2-2                                 "));
            motoresBkp.Add(new Motor("1009", "G8A	", "33110-M-1347	", "Ventilador de circ de ar T2-3                                 "));
            motoresBkp.Add(new Motor("1009", "G8B	", "33110-M-1348	", "Ventilador de circ de ar T2-4                                 "));
            motoresBkp.Add(new Motor("1009", "G8C	", "33110-M-1349	", "Ventilador de circ de ar T2-5                                 "));
            motoresBkp.Add(new Motor("1009", "G8D	", "33110-M-1350	", "Ventilador de circ de ar T2-6                                 "));
            motoresBkp.Add(new Motor("1009", "G8E	", "33110-M-1646	", "Ventilador de exaustão de ar do pulper                        "));
            motoresBkp.Add(new Motor("1009", "G8F	", "33110-M-1648	", "Ventilador rampa de quebra                                    "));
            motoresBkp.Add(new Motor("1009", "G8G	", "33110-M-1647	", "Ventilador de exaustão de ar do removedor de pó               "));
            motoresBkp.Add(new Motor("1009", "G9A	", "33110-M-1650	", "Rolo abridor de retorno                                       "));
            motoresBkp.Add(new Motor("1009", "G9C	", "33110-M-1689	", "Central de limpeza                                            "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-1134	", "Acionador de tela inferior                            "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-1136	", "Rolo sucção                                           "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-1137	", "Rolo Feltro do circuito pick up                       "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-1138	", "Rolo acionador 2 prensa                               "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-1139	", "Rolo superior prensa sapata                           "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-1140	", "Rolo abridor 1                                        "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-1141	", "Rolo guia 1                                           "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-1142	", "Transportador de quebra                               "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-1154	", "Acionamento Rolo Formador                             "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-1651	", "Rolo guia 2                                           "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-1652	", "Rolo guia 3                                           "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-1653	", "Rolo de retorno parte umida                           "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-1665	", "Rolo de retorno parte seca                            "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-1678	", "Fita de passagem de ponta                             "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-1986	", "Rolo guia 4                                           "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-1988	", "Rolo tracionador inferior                             "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-1999	", "Rolo de alimentação                                   "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-3001	", "Faca circulares                                       "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-3002	", "Prensa alimentacao principal                          "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-3003	", "Rolo facão                                            "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-3004	", "Rolo sobreposição                                     "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-3005	", "Rolo suporte                                          "));
            motoresBkp.Add(new Motor("PINV1013", "		", "33110-M-3006	", "Rolo alimentacao de layboy                            "));
            motoresBkp.Add(new Motor("QSA-1001", "	G7H	", "33110-M-3062	", "Reserva técnica                                       "));
            motoresBkp.Add(new Motor("QSA-1001", "	G7I	", "33110-M-3061	", "Reserva técnica                                       "));
            motoresBkp.Add(new Motor("1006	 ", "C33F	", "33110-M-1549	", "Ventilador de circ de ar T22-5                        "));
            motoresBkp.Add(new Motor("1006	 ", "C33G	", "33110-M-1550	", "Ventilador de circ de ar T22-6                        "));
            motoresBkp.Add(new Motor("PINV1006", "	N/A	", "33110-M-1642	", "Ventilador de resfriamento de ar 1                    "));
            motoresBkp.Add(new Motor("PINV1007", "	N/A	", "33110-M-1643	", "Ventilador de resfriamento de ar 2                    "));
            motoresBkp.Add(new Motor("PINV1008", "	N/A	", "33110-M-1644	", "Ventilador de resfriamento de ar 3                    "));
            motoresBkp.Add(new Motor("PINV1009", "	N/A	", "33110-M-1645	", "Ventilador de resfriamento de ar 4                    "));
            motoresBkp.Add(new Motor("PINV1011", "	N/A	", "33110-M-1046	", "Rotor 2 Pulper úmido                                  "));
            #endregion

            motores.AddRange(motoresBkp);
            motorBindingSource.DataSource = motores;
            cmbTipoPesq.SelectedIndex = 0;
            dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            limparImagem();
            dataGridView1.DataBindingComplete -= DataGridView1_DataBindingComplete;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmbTipoPesq.SelectedIndex = 0;
            txtPesquisa.Text = null;
            dataGridView1.ClearSelection();
            buscar();
            limparImagem();
        }

        private void limparImagem()
        {
            lbImagem.Image = Properties.Resources.geral_ajustado;
        }

        private void buscar()
        {
            motores.Clear();
            if (string.IsNullOrEmpty(txtPesquisa.Text))
                motores.AddRange(motoresBkp);
            else
            {
                if (cmbTipoPesq.SelectedIndex == 0) //CCM
                    motores.AddRange(motoresBkp.Where(x => x.ccm.Equals(txtPesquisa.Text)));
                else //TAG
                    motores.AddRange(motoresBkp.Where(x => x.tag.Equals(txtPesquisa.Text)));
            }
            motorBindingSource.ResetBindings(false);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                limparImagem();
                return;
            }
            var ccm = (dataGridView1.SelectedCells[0].OwningRow.DataBoundItem as Motor).ccm;
            lbImagem.Image = Properties.Resources.ResourceManager.GetObject(ccm) as Bitmap;
            if (lbImagem.Image == null)
                limparImagem();
        }

        private void txtPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buscar();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0 || dataGridView1.SelectedCells[0].ColumnIndex != 2)
                return;
            var tag = (dataGridView1.SelectedCells[0].OwningRow.DataBoundItem as Motor).tag;
            var caminho = string.Format("{0}\\PDF\\{1}.pdf", System.IO.Directory.GetCurrentDirectory(), tag);
            if (System.IO.File.Exists(caminho))
                System.Diagnostics.Process.Start(caminho);
            else
                MessageBox.Show(string.Format("Arquivo {0} não encontrado.", caminho));
        }
    }
}
