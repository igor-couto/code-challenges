using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AbsoluteValuesSumMinimization.Benchmark;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class Benchmark
{
    private int[] array = new[] {448695, 827966, 950274, 712158, 753494, 552684, 932729, 276875, 593685, 184918, 872369, 896217, 347612, 524138, 971786, 289543, 351804, 700156, 499230, 356714, 524499, 824679, 168917, 451926, 900788, 347549, 127940, 640318, 703851, 181535, 127428, 750645, 800993, 657182, 123698, 682057, 798984, 296173, 709063, 151406, 959714, 180621, 463689, 902472, 652430, 809146, 146892, 801602, 603374, 761605, 366971, 601530, 168038, 999541, 888597, 225781, 281792, 421089, 385204, 633817, 316987, 978868, 835427, 791806, 408789, 237461, 413951, 983690, 755748, 546823, 122239, 249710, 469078, 715492, 345102, 371960, 862123, 870695, 532354, 912493, 718804, 139204, 398640, 481679, 861152, 916135, 904785, 706932, 778439, 840554, 367384, 127401, 826475, 536194, 272452, 803479, 652835, 927246, 396573, 976513, 829821, 379123, 668646, 841196, 918437, 849230, 977395, 689041, 986237, 661439, 305028, 471678, 730184, 725682, 611751, 985315, 515132, 211427, 258429, 142870, 761612, 322710, 719062, 349206, 911107, 124967, 802305, 893613, 900840, 340341, 291366, 214596, 650881, 513169, 711858, 230172, 744795, 879456, 208753, 444087, 634651, 497040, 975259, 296557, 294258, 875951, 344840, 198713, 461490, 803173, 130192, 753049, 832824, 613742, 899103, 826165, 611370, 316316, 202458, 753760, 444809, 532130, 569241, 440797, 256841, 384016, 788740, 778700, 809337, 903659, 414365, 430651, 404062, 940451, 387129, 477815, 111858, 231767, 563596, 468318, 663718, 891542, 170286, 674046, 349237, 793506, 792973, 162753, 724312, 580466, 664036, 935771, 116173, 849159, 965424, 153593, 192925, 280370, 518977, 481424, 911458, 739423, 654216, 846854, 692450, 810914, 588201, 915217, 324346, 271583, 242004, 526703, 261783, 692325, 451957, 161765, 207213, 631019, 679531, 950271, 408129, 980184, 105163, 833392, 619452, 215606, 617903, 542071, 989755, 889097, 501157, 930915, 648648, 427593, 586286, 984113, 547019, 889730, 478019, 344551, 768529, 419951, 810273, 284812, 737166, 618255, 321181, 903579, 179487, 553095, 105747, 274646, 895696, 276142, 270697, 150255, 968183, 458261, 769548, 980620, 988461, 620423, 238283, 823153, 699103, 450492, 199107, 286265, 438690, 118520, 504783, 812062, 110387, 525665, 286953, 115887, 869116, 941885, 619547, 248671, 786394, 206726, 470272, 664381, 365694, 918215, 869987, 153861, 607763, 946526, 440812, 496125, 904626, 539455, 124164, 939940, 280106, 268292, 440645, 919197, 615254, 453878, 531079, 792844, 808785, 743479, 569002, 332205, 758089, 362919, 259541, 950115, 156926, 621956, 730728, 525160, 120389, 211881, 991363, 938837, 738001, 407490, 888198, 272856, 230488, 477672, 980879, 838468, 774610, 241447, 847672, 502707, 748859, 595212, 994829, 732442, 431502, 511857, 547286, 827201, 239631, 943007, 188761, 828758, 480072, 720029, 578222, 496331, 276072, 834153, 925451, 868305, 243704, 574735, 607485, 308557, 335731, 693696, 236388, 506611, 315369, 678887, 635864, 416359, 943244, 244671, 607654, 821545, 287848, 702275, 707704, 870227, 694081, 986221, 694439, 623089, 478842, 773813, 490536};

    [Benchmark]
    public void AbsoluteValuesSumMinimization_Naive() 
        => Solution.AbsoluteValuesSumMinimization_Naive(array);

    [Benchmark]
    public void AbsoluteValuesSumMinimization_SecondAttempt() 
        => Solution.AbsoluteValuesSumMinimization_SecondAttempt(array);

    [Benchmark]
    public void AbsoluteValuesSumMinimization_NaiveButALittleBetter() 
        => Solution.AbsoluteValuesSumMinimization_NaiveButALittleBetter(array);

    [Benchmark]
    public void AbsoluteValuesSumMinimization_BestSolution() 
        => Solution.AbsoluteValuesSumMinimization_BestSolution(array);
}