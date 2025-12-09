namespace MostFrequentWordsLINQ
{
    internal class Program
    {
        internal static readonly char[] separator = [' ', '.', ',', ';', '!', '?', ':', '-', '\'', '"'];

        static void Main(string[] args)
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam sagittis nisi at arcu auctor lacinia. Vestibulum molestie convallis ex, et cursus ipsum lobortis quis. Nullam ipsum eros, vulputate ut tortor et, gravida imperdiet arcu. In lacinia enim quis efficitur sollicitudin. Morbi lobortis molestie dolor. Mauris non vestibulum arcu. Duis venenatis enim eget metus rutrum eleifend. Nam urna dui, gravida sed iaculis in, laoreet et lectus. Donec blandit ligula non risus volutpat, vitae laoreet velit consectetur. In a odio maximus, vulputate nibh nec, ultrices felis. Ut vel quam aliquam, sollicitudin urna in, dapibus massa. Nunc sed dolor pharetra, laoreet dolor vel, facilisis nisi.Nulla sodales justo ultricies odio congue, vitae ullamcorper turpis porta. Nunc consequat in velit in semper. Maecenas lectus mi, interdum ut mi sit amet, scelerisque euismod est. Fusce scelerisque diam nunc, id accumsan justo cursus quis. Cras et finibus nunc, vitae egestas quam. Nunc pellentesque tempor metus at rutrum. Curabitur ut tincidunt odio. Pellentesque vel velit lacinia, tristique nisi vel, dictum leo. Pellentesque eu nibh in ante bibendum iaculis.Proin aliquam tincidunt nisi, eu gravida odio eleifend sit amet. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Aliquam in nunc nisi. Nam vulputate quam id purus porta eleifend. Nulla commodo vulputate leo, et vehicula nisi facilisis in. Quisque velit enim, egestas vel dictum ac, imperdiet id nisl. Cras et feugiat magna. Nullam fringilla sodales facilisis. Suspendisse scelerisque, urna sed aliquam volutpat, felis augue aliquam libero, sed faucibus dui justo a ligula. Phasellus at velit erat. In placerat lorem ac elementum congue. In non condimentum diam. Nam dignissim sodales arcu, eu tristique arcu euismod vitae. Aliquam erat volutpat. Vivamus fermentum et purus a condimentum. Nam enim tellus, malesuada in hendrerit a, semper non nisi.";

            var top3Words = text
                .Split(separator, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .GroupBy(word => word)
                .Select(group => new { Word = group.Key, Count = group.Count() })
                .OrderByDescending(x => x.Count)
                .ThenBy(x => x.Word)
                .Take(3);

            foreach (var item in top3Words)
            {
                Console.WriteLine($"{item.Word} - {item.Count}");
            }
        }
    }
}
