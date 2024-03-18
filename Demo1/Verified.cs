namespace Demo1
{
    public static class Verified
    {
        public static bool VerifiedInfluencer(this Influencer influencer)
        {
            if (influencer.Followers > 1000)
            {
                return true;
            }

            return false;

        }

        public static bool VerifiedString(this string text)
        {
            if (text.EndsWith('\n'))
            {
                return true;
            }

            return false;
        }

    }
}
