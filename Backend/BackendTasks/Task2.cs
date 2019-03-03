using System.Collections.Generic;

namespace BackendConsoleApp
{
    public static class Task2
    {
        /// <summary>
        /// Returns a string detailing the likes based on the content and number if items of the provided list of names
        /// </summary>
        /// <param name="likedByNameList"></param>
        /// <returns>String detailing likes for the provided list of names</returns>
        public static string GenerateLikesString(IList<string> likedByNameList)
        {
            int likedByCount = likedByNameList == null ? 0 : likedByNameList.Count;

            switch(likedByCount)
            {
                case 0:
                    return "no one likes this";
                case 1:
                    return $"{likedByNameList[0]} likes this";
                case 2:
                    return $"{likedByNameList[0]} and {likedByNameList[1]} like this";
                case 3:
                    return $"{likedByNameList[0]}, {likedByNameList[1]} and {likedByNameList[2]} like this";
                default:
                    return $"{likedByNameList[0]}, {likedByNameList[1]} and {likedByCount - 2} others like this";
            }
        }
    }
}
