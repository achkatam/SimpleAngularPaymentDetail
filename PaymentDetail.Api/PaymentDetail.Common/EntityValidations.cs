namespace PaymentDetail.Common;

public static class EntityValidations
{
    public static class PaymentValidations
    {
        public const int CARD_OWNER_NAME_MAX_LENGTH = 100;
        public const int CARD_OWNER_NAME_MIN_LENGTH = 3;
            
        public const int CARD_NUMBER_MAX_LENGTH = 16;
        public const int CARD_NUMBER_MIN_LENGTH = 16;

        public const int EXPIRATION_DATE_MAX_LENGTH = 5;
        public const int EXPIRATION_DATE_MIN_LENGTH = 5;

        public const int SECURITY_CODE_MAX_LENGTH = 3;
        public const int SECURITY_CODE_MIN_LENGTH = 3; 
    }
} 