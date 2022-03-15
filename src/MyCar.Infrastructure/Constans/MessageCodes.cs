namespace MyCar.Infrastructure.Constans
{
    public static class MessageCodes
    {
        private static string GeneralCodePrefix = "";
        private static string SuccessCodePrefix = "";
        private static string ErrorCodePrefix = "";
        private static string WarningCodePrefix = "";
        private static string InformationCodePrefix = "";

        public static class General
        {
            public static string GeneralCode = GeneralCodePrefix + "0";
            public static string NotFound = GeneralCodePrefix + "1";
            public static string Exist = GeneralCodePrefix + "2";
            public static string NotExist = GeneralCodePrefix + "3";
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

    }
}
