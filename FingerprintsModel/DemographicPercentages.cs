using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerprintsModel
{
   public class DemographicPercentages
    {

        public string HadDoctor { get; set; }
        public string HadDentist { get; set; }
        public string HadInsurance { get; set; }
        public string HadDisability { get; set; }

        public string HadAttendanceIssue { get; set; }
        public string ParentWorking { get; set; }

        public string ParentTraining { get; set; }
        public string NonEnglistSpeakers { get; set; }
        public string CEnglishSpeakers { get; set; }
        public string CAfricanSpeakers { get; set; }

        public string CCaribeanSpeakers { get; set; }
        public string CEastAsianSpeakers { get; set; }

        public string CEuropeanSpeakers { get; set; }

        public string CMidEasternSpeakers { get; set; }
        public string CNativeCentralSpeakers { get; set; }

        public string CNorthAmericanSpeakers { get; set; }
        public string CPacificSpeakers { get; set; }

        public string CSpanishSpeakers { get; set; }

        public string SEnglishSpeakers { get; set; }
        public string SAfricanSpeakers { get; set; }

        public string SCaribeanSpeakers { get; set; }
        public string SEastAsianSpeakers { get; set; }

        public string SEuropeanSpeakers { get; set; }

        public string SMidEasternSpeakers { get; set; }
        public string SNativeCentralSpeakers { get; set; }

        public string SNorthAmericanSpeakers { get; set; }
        public string SPacificSpeakers { get; set; }

        public string SSpanishSpeakers { get; set; }

        public string SNonEthinic { get; set; }
        public string SEthinic { get; set; }
        public string CNonEthinic { get; set; }
        public string CEthinic { get; set; }

        public string CRaceAmericanIndian { get; set; }
        public string CRaceAsian { get; set; }
        public string CRaceBiracial { get; set; }


        public string CRaceBlack { get; set; }

        public string CRaceWhite { get; set; }
        public string CRaceHwalian { get; set; }
        public string CRaceOther { get; set; }

        public string SRaceAmericanIndian { get; set; }
        public string SRaceAsian { get; set; }
        public string SRaceBiracial { get; set; }


        public string SRaceBlack { get; set; }

        public string SRaceWhite { get; set; }
        public string SRaceHwalian { get; set; }
        public string SRaceOther { get; set; }

        public string FSWAvgAge { get; set; }
        public string TeacherAvgAge { get; set; }
        public string FamiliesAvgAge { get; set; }
    }

    public class DemoGraphicPercentage
    {
       
        public string TotalParent { get; set; }
        public string TotalClient { get; set; }
        public string WorkingParent { get; set; }
        public string WorkingParentPercent { get; set; }
        public string Insurance { get; set; }
        public string InsurancePercent { get; set; }
        public string JobParent { get; set; }
        public string JobParentPercent { get; set; }

        public string ClientDoctor { get; set; }
        public string ClientDoctorPercent { get; set; }
        public string ClientDental { get; set; }

        public string ClientDentalPercent { get; set; }
        public string ClientDisability { get; set; }
        public string ClientDisablilyPercent { get; set; }
        public string AttendanceIssue { get; set; }
        public string AttendIssuePercent { get; set; }
        public string OtherLangSpeakers { get; set; }
        public string OtherLangSpeakersPercent { get; set; }
        public string EnglishLang { get; set; }
        public string AfricanLang { get; set; }
        public string CaribbeanLang { get; set; }
        public string EastAsianLang { get; set; }
        public string EuropeanLang { get; set; }
        public string MiddleLang { get; set; }
        public string NativeCenterLang { get; set; }
        public string NativeNorthLang { get; set; }
        public string PacificLang { get; set; }
        public string SpanisLang { get; set; }
    }
}
