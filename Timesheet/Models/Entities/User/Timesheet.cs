using System.ComponentModel.DataAnnotations;

namespace Timesheet.Models.Entities.User
{
    public class Timesheet
    {
        [Key]
        public long autoNumber { get; set; }

        public int persCode { get; set; }

        [MaxLength(50)]
        public string? fName { get; set; }

        [MaxLength(50)]
        public string? lName { get; set; }

        [MaxLength(50)]
        public string? domainName { get; set; }

        [MaxLength(50)]
        public string? userName { get; set; }

        [MaxLength(100)]
        public string? email { get; set; }

        [MaxLength(10)]
        public string? date { get; set; }

        [MaxLength(50)]
        public string? discipline { get; set; }

        [MaxLength(50)]
        public string? prjCode { get; set; }

        [MaxLength(200)]
        public string? prjName { get; set; }

        [MaxLength(50)]
        public string? phase { get; set; }

        [MaxLength(50)]
        public string? docCode { get; set; }

        [MaxLength(200)]
        public string? docName { get; set; }

        public int? pPercent { get; set; }

        public int? missionM { get; set; }

        public int? homeWorkM { get; set; }

        public int? extraWork { get; set; }

        public int? vacationM { get; set; }

        public int? vacationPayM { get; set; }

        public int? delayPercM { get; set; }

        public int? iExitM { get; set; }

        public int? absenceM { get; set; }

        public int? overTimeM { get; set; }

        public float? dMWork { get; set; }

        public int? tMWork { get; set; }

        public int? timeSheetMWork { get; set; }

        [MaxLength(5)]
        public string? interTime { get; set; }

        [MaxLength(5)]
        public string? exitTime { get; set; }

        [MaxLength(10)]
        public string? dayOfWeek { get; set; }

        public int? extraMissionM { get; set; }

        public int? sumM_tMWork_extraWork_extraMission_homeWork_extraWorkFraction { get; set; }

        public int? flag { get; set; }

        public int? dailyPercent { get; set; }

        public int? extraWorkFraction { get; set; }

        [MaxLength(50)]
        public string? fNamePersian { get; set; }

        [MaxLength(50)]
        public string? lNamePersian { get; set; }

        [MaxLength(100)]
        public string? description1 { get; set; }

        [MaxLength(100)]
        public string? description2 { get; set; }

        [MaxLength(100)]
        public string? personnelDepartment { get; set; }

        public int? monthlyDue { get; set; }

        public int? overtimeLimitM { get; set; }

        public int? extraWorkLimitM { get; set; }

        public int? paymentLimitM { get; set; }

        [MaxLength(50)]
        public string? contractType { get; set; }

        [MaxLength(50)]
        public string? company { get; set; }

        public int? inMissionM { get; set; }

        [MaxLength(50)]
        public string? month { get; set; }

        [MaxLength(9)]
        public string? year { get; set; }

        [MaxLength(7)]
        public string? period { get; set; }

        public int? holiday { get; set; }

        public bool DepHead { get; set; }
        public bool PrjHead { get; set; }
        public bool EngHead { get; set; }
        public bool GasDpt { get; set; }
        public bool SupDpt { get; set; }
        public bool WtrDpt { get; set; }
        public bool Ceo { get; set; }
        public string? NotAccept { get; set; }

    }

}
