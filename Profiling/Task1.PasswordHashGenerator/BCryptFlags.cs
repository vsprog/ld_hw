namespace Task1.PasswordHashGenerator
{
    /// <summary>
    /// Flags for BCrypt functions
    /// </summary>
    public enum BCryptFlags : int
    {
        /// <summary>
        /// No flags
        /// </summary>
        NO_FLAGS = 0,
        /// <summary>
        /// Hash provider operates in HMAC mode
        /// </summary>
        BCRYPT_ALG_HANDLE_HMAC_FLAG = 0x8
    }
}
