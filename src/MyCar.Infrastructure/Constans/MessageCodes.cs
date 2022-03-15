namespace MyCar.Infrastructure.Constans
{
    public static class MessageCodes
    {
        private static string GeneralCodePrefix = "GC-0-";
        private static string SuccessCodePrefix = "SC-1-";
        private static string ErrorCodePrefix = "EC-2-";
        private static string WarningCodePrefix = "WC-3-";
        private static string InformationCodePrefix = "IC-4-";
        private static string CandidateCodePrefix = "CC-5-";

        public static class General
        {
            public static string GeneralCode = GeneralCodePrefix + "0";
            public static string NotFound = GeneralCodePrefix + "1";
            public static string Exist = GeneralCodePrefix + "2";
            public static string NotExist = GeneralCodePrefix + "3";
            public static string EnteredInfoFalse = GeneralCodePrefix + "4";
            public static string NotActive = GeneralCodePrefix + "5";
            public static string ApplicationException = GeneralCodePrefix + "6";
            public static string EmailNotConfirm = GeneralCodePrefix + "7";
            public static string EmailNotConfirmed = GeneralCodePrefix + "8";
            public static string EmailIsAlreadyConfirmed = GeneralCodePrefix + "9";
            public static string EmailAndUserTypeAlreadyExist = GeneralCodePrefix + "10";
            public static string ImageTypeNotValid = GeneralCodePrefix + "11";
            public static string FileTypeNotValid = GeneralCodePrefix + "12";
            public static string FileSizeNotValid = GeneralCodePrefix + "13";
            public static string FileNotUploaded = GeneralCodePrefix + "14";
            public static string UnAuthorized = GeneralCodePrefix + "15";
            public static string Forbidden = GeneralCodePrefix + "16";
            public static string NotEmployerActive = GeneralCodePrefix + "17";
        }

        public static class Success
        {
            public static string SuccessCode = SuccessCodePrefix + "0";
            public static string Get = SuccessCodePrefix + "1";
            public static string Created = SuccessCodePrefix + "2";
            public static string Edited = SuccessCodePrefix + "3";
            public static string Deleted = SuccessCodePrefix + "4";
        }

        public static class Error
        {
            public static string ErrorCode = ErrorCodePrefix + "0";
            public static string Get = ErrorCodePrefix + "1";
            public static string Created = ErrorCodePrefix + "2";
            public static string Edited = ErrorCodePrefix + "3";
            public static string Deleted = ErrorCodePrefix + "4";
        }

        public static class Warning
        {
            public static string WarningCode = WarningCodePrefix + "0";
            public static string Get = WarningCodePrefix + "1";
            public static string Created = WarningCodePrefix + "2";
            public static string Edited = WarningCodePrefix + "3";
            public static string Deleted = WarningCodePrefix + "4";
        }

        public static class Information
        {
            public static string InformationCode = InformationCodePrefix + "0";
            public static string Get = InformationCodePrefix + "1";
            public static string Created = InformationCodePrefix + "2";
            public static string Edited = InformationCodePrefix + "3";
            public static string Deleted = InformationCodePrefix + "4";
        }

        public static class Candidate
        {
            public static string UserIdNotMatched = CandidateCodePrefix + "0";
            public static string UserTypeNotMatched = CandidateCodePrefix + "1";
            public static string UserNameNotFound = CandidateCodePrefix + "2";
            public static string EmailUpdated = CandidateCodePrefix + "3";
            public static string ContactInformationNotFound = CandidateCodePrefix + "4";
        }
    }
}
