using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemostration
{
    class Program
    {
        static string GetCodePoint(string input, int index)
        {
            if (Char.IsSurrogatePair(input, index))
                return string.Format("U+{0:X8}", Char.ConvertToUtf32(input, index));
            return string.Format("U+{0:X4}", Char.ConvertToUtf32(input, index));
        }

        static void Main(string[] args)
        {
            //var patterns = new List<string> { "a*b", "a+b", "a?b" };
            //var inputs = new List<string> { "a", "b", "ab", "aab", "abb" };

            //patterns.ForEach(pattern =>
            //{
            //    Console.WriteLine("Regular expression: {0}", pattern);
            //    var regex = new Regex(pattern);
            //    inputs.ForEach(input =>
            //    {
            //        Console.WriteLine("\tInput pattern: {0}", input);
            //        var results = regex.Matches(input);
            //        if (results.Count <= 0)
            //            Console.WriteLine("\t\tNo matches found.");
            //        foreach (Match result in results)
            //            Console.WriteLine("\t\tMatch found at index {0}. Length: {1}", result.Index, result.Length);
            //    });
            //});

            //var patterns = new List<string>()
            //{
            //    //@"^\d\d\d-\d\d\d-\d\d\d\d$"
            //    @"^(0|1|2|3|4|5|6|7|8|9)\d\d-\d\d\d-\d\d\d\d$"
            //};

            //var inputs = new List<string>()
            //{
            //    "5555555555",
            //    "(555)-555-5555",
            //    "012-345-6789",
            //    "555-555-5555",
            //    "555-555-555a",
            //    "5555-555-5555",
            //    "555-5555555",
            //    "000-000-0000",
            //    "a",
            //    "5.55-555-5555",
            //    "...-...-...."
            //};

            //patterns.ForEach(pattern =>
            //{
            //    Console.WriteLine("Regular expression: {0}", pattern);
            //    var regex = new Regex(pattern);
            //    inputs.ForEach(input =>
            //    {
            //        Console.WriteLine("\tInput pattern: {0}", input);
            //        var isMatch = regex.IsMatch(input);
            //        Console.WriteLine("\t\t{0}", isMatch ? "Accepted" : "Rejected");
            //        if (!isMatch)
            //            return;
            //        var splits = Regex.Split(input, @"-\d\d\d-").ToList();
            //        Console.WriteLine("\t\t\tArea code: {0}", splits[0]);
            //        Console.WriteLine("\t\t\tLast 4 digits: {0}", splits[1]);
            //    });
            //});

            //var patterns = new List<string>() { @"([A-Za-z]+).*\$(\d+.\d+)" };

            //var inputs = new List<string> {
            //    @"
            //      |---------------------| 
            //      | Receipt from        |
            //      | Alexandru's shop    |
            //      |                     |
            //      | Thanks for shopping!|
            //      |---------|-----------|
            //      | Item    | Price $USD|
            //      |---------|-----------|
            //      | Shoes   |    $47.99 |
            //      | Cabbage |     $2.99 |
            //      | Carrots |     $1.23 |
            //      | Chicken |     $9.99 |
            //      | Beef    |    $12.47 |
            //      | Shirt   |     $5.97 |
            //      | Salt    |     $2.99 |
            //      |---------|-----------|"
            //};

            //patterns.ForEach(pattern =>
            //{
            //    Console.WriteLine("Regular expression: {0}", pattern);
            //    var regex = new Regex(pattern);
            //    inputs.ForEach(input =>
            //    {
            //        Console.WriteLine("\tInput pattern: {0}", input);
            //        var matches = regex.Matches(input);
            //        if (matches.Count <= 0)
            //            Console.WriteLine("\t\tNo matches found.");
            //        foreach (Match match in matches)
            //        {
            //            Console.WriteLine("\t\tMatch at index {0} with length {1}", match.Index, match.Length);
            //            foreach (Group group in match.Groups)
            //            {
            //                Console.WriteLine("\t\t\tGroup at index {0} has value {1}", group.Index, group.Value);
            //            }
            //        }
            //        Console.WriteLine("Simple replacement results: {0}",
            //                Regex.Replace(input, @"(Chicken)(.*) \$(9.99)", @"$1$2 $$0.00"));
            //        var results = Regex.Replace(input, pattern, (match) =>
            //        {
            //            if (match.Groups[1].Value == "Chicken")
            //                return match.Value.Replace(match.Groups[2].Value, "0.00");
            //            return match.Value;
            //        });
            //        Console.WriteLine("Advanced replacement results: {0}", results);
            //    });
            //});

            //clase
            //var patterns = new List<string>()
            //{
            //    @"\b",
            //    @"\B",
            //    @"^hi",
            //    @"hi$"
            //};

            //var inputs = new List<string>()
            //{
            //    "a b",
            //    "a",
            //    " ",
            //    "",
            //    "hi",
            //    " hi",
            //    "him",
            //    " him",
            //    "him "
            //};

            //patterns.ForEach(pattern =>
            //{
            //    Console.WriteLine("Regular expression: {0}", pattern);
            //    var regex = new Regex(pattern);
            //    inputs.ForEach(input =>
            //    {
            //        Console.WriteLine("\tInput pattern: {0}", input);
            //        var results = regex.Matches(input);
            //        if (results.Count <= 0)
            //            Console.WriteLine("\t\tNo matches found.");
            //        foreach (Match result in results)
            //        {
            //            Console.WriteLine("\t\tMatch found at index {0}. Length: {1}.",
            //                result.Index,
            //                result.Length);
            //        }
            //    });
            //});


            //Clase
            //var patterns = new List<string>()
            //{
            //    "(?x)Hey#This is a comment",
            //    "He(?# This is a comment...)y",
            //    "H(?i)e(?-i)y",
            //    @"(?m)^hey$",
            //    "(he)y",
            //    "(?n)(he)(?-n)y",
            //    "(?x) \r\n h e y"
            //};

            //var inputs = new List<string>()
            //{
            //    "hey\nhey",
            //    " hey\nhey",
            //    " hey\n hey",
            //    "Hey",
            //    "hey",
            //    "HEy",
            //    "HEY",
            //    " hey",
            //    "hey ",
            //    " hey "
            //};

            //patterns.ForEach(pattern =>
            //{
            //    Console.WriteLine("Regular expression: \"{0}\"", pattern);
            //    var regex = new Regex(pattern);
            //    inputs.ForEach(input =>
            //    {
            //        Console.WriteLine("\tInput pattern: \"{0}\"", input);
            //        var results = regex.Matches(input);
            //        if (results.Count <= 0)
            //            Console.WriteLine("\t\tNo maatches found.");
            //        foreach (Match match in results)
            //        {
            //            Console.WriteLine("\t\tMatch found at index {0}. Length: {1}.",
            //                match.Index,
            //                match.Length);
            //            foreach (Group group in match.Groups)
            //                Console.WriteLine("\t\t\tGroup at index {0} has value {1}",
            //                    group.Index,
            //                    group.Value);
            //        }
            //    });
            //});

            //Clase
            //var patterns = new List<string>()
            //{
            //    @"<.+>",
            //    @"<.+?>",
            //    @"(a+(aa)+(aaa)+(aa)+a+)+b."
            //};

            //var inputs = new List<string>()
            //{
            //    "a<tag>b</tag>c",
            //    "aaaaaaaaaaaaaaaaaaab",
            //    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab"
            //};

            //patterns.ForEach(pattern =>
            //{
            //    Console.WriteLine("Regular expression: {0}", pattern);
            //    var regex = new Regex(pattern);
            //    inputs.ForEach(input =>
            //    {
            //        Console.WriteLine("\tInput pattern: {0}", input);
            //        var watch = new Stopwatch();
            //        watch.Start();
            //        var results = regex.Matches(input);
            //        if (results.Count <= 0)
            //            Console.WriteLine("\t\tNo matches found.");
            //        foreach (Match result in results)
            //            Console.WriteLine("\t\tMatch found at index {0}. Length: {1}.", result.Index, result.Length);
            //        watch.Stop();
            //        Console.WriteLine("\t\tRuntime: {0}ms", watch.Elapsed.TotalMilliseconds);
            //    });
            //});

            //Clase
            //var input = "a";
            //Console.WriteLine(input);
            //Console.WriteLine("\tCode point: {0}", GetCodePoint(input, 0));
            //Console.WriteLine("\tLength: {0}", input.Length);

            //Console.WriteLine("\tIs uppercase letter? {0}", Regex.IsMatch(input, @"\p{Lu}"));
            //Console.WriteLine("\tIs not an uppercase letter? {0}", Regex.IsMatch(input, @"\P{Lu}"));

            //input = "❌";
            //Console.WriteLine("Cross Mark");
            //Console.WriteLine("\tCode point: {0}", GetCodePoint(input, 0));
            //Console.WriteLine("\tLength: {0}", input.Length);

            //Console.WriteLine("\tDoes the input match \\u274C? {0}", Regex.IsMatch(input, "\u274C"));

            //Console.WriteLine("\tIs in Dingbats? {0}", Regex.IsMatch(input, @"\p{IsDingbats}")); //Dingbats are from U+2700 to U+27BF
            //Console.WriteLine("\tIs not in Dingbats? {0}", Regex.IsMatch(input, @"\P{IsDingbats}"));

            //input = "😎";
            //Console.WriteLine("Smiling Face with Sunglasses Emoji");
            //Console.WriteLine("\tCode point: {0}", GetCodePoint(input, 0));
            //Console.WriteLine("\tLength: {0}", input.Length);

            //Console.WriteLine("\tDoes the emoji match \\U0001F60E? {0}", Regex.IsMatch(input, "\U0001F60E"));

            //input = "İ"; //In Turkish, capital i is not I. It is İ.
            //var _pattern = "i";

            //Console.WriteLine("Turkish Culture");
            //Console.WriteLine("\tMatches without CultureInvariant? {0}", Regex.IsMatch(input, _pattern, RegexOptions.IgnoreCase));
            //Console.WriteLine("\tMatches with CultureInvariant? {0}", Regex.IsMatch(input, _pattern, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant));

            //Clase
            //var input = "µ";
            //var pattern = "μ";

            //Console.WriteLine("Micro and Mu Symbols:");
            //Console.WriteLine("\tDoes {0} match {1}? {2}", pattern, input, Regex.IsMatch(input, pattern));

            //Console.WriteLine("\tInput's code point: {0}", GetCodePoint(input, 0));
            //Console.WriteLine("\tPattern's code point: {0}", GetCodePoint(pattern, 0));

            //input = "مرحبا بالعالم مرحبا";
            //pattern = @"مرحبا";

            //Console.WriteLine("Right to Left Option:");
            //Console.WriteLine("\tWithout the RightToLeft option:");
            //foreach(Match match in Regex.Matches(input, pattern))
            //{
            //    Console.WriteLine("\t\tMatch at index {0} of length {1}", match.Index, match.Length);
            //}

            //Console.WriteLine("\tWith the RightToLeft option:");
            //foreach (Match match in Regex.Matches(input, pattern, RegexOptions.RightToLeft))
            //    Console.WriteLine("\t\tMatch at index {0} of length {1}", match.Index, match.Length);

            //input = "Hello world.";
            //var patterns = new List<string> { @"\b\w+\b", @"\b(\w)+\b" };
            //Console.WriteLine("Captures:");
            //foreach(var examplePattern in patterns)
            //{
            //    Console.WriteLine("\tInput: {0}", input);
            //    Console.WriteLine("\tPattern: {0}", examplePattern);
            //    foreach(Match match in Regex.Matches(input, examplePattern))
            //    {
            //        Console.WriteLine("\t\t{0}: Match at index {1} of length {2}", match.Value, match.Index, match.Length);
            //        foreach(Group group in match.Groups)
            //        {
            //            Console.WriteLine("\t\t\t{0}: Group at index {1} of length {2}", group.Value, group.Index, group.Length);
            //            foreach(Capture capture in group.Captures)
            //            {
            //                Console.WriteLine("\t\t\t\t{0}: Capture at index {1} of length {2}", capture.Value, capture.Index, capture.Length);
            //            }
            //        }
            //    }
            //}

            //input = @"{]";
            //pattern = @"^((?:[^{}]*)|(?<Open>{)|(?<-Open>}))*$";
            //Console.WriteLine("Balancing Groups:");
            //Console.WriteLine("\tInput: {0}", input);
            //Console.WriteLine("\tPattern: {0}", pattern);
            //Console.WriteLine("\tIs {0} balanced? {1}", input, Regex.IsMatch(input, pattern));
            //input = @"{}}";
            //Console.WriteLine("\tIs {0} balanced? {1}", input, Regex.IsMatch(input, pattern));
            //input = @"{}{";
            //Console.WriteLine("\tIs {0} balanced? {1}", input, Regex.IsMatch(input, pattern));
            //input = @"}{";
            //Console.WriteLine("\tIs {0} balanced? {1}", input, Regex.IsMatch(input, pattern));
            //input = @"{ {} {   }}";
            //Console.WriteLine("\tIs {0} balanced? {1}", input, Regex.IsMatch(input, pattern));

            //Console.WriteLine("Nested Captures:");
            //input = @"{ 1 { 2 3 } { 4 { 5 } 6 } 7 }";
            //pattern = @"^((?:[^{}]*)|(?<Open>{)|(?<Contents-Open>}))*(?(Open)(?!))$";

            //Console.WriteLine("\tInput: {0}", input);
            //Console.WriteLine("\tPattern: {0}", pattern);
            //var matches = Regex.Matches(input, pattern);
            //var contens = matches[0].Groups["Contents"];
            //Console.WriteLine("\t{0} Group:", contens.Name);
            //foreach (Capture capture in contens.Captures)
            //    Console.WriteLine("\t\t{0}: Capture at index {1} of length {2}", capture.Value, capture.Index, capture.Length);

            Console.WriteLine("Interpreted Regex:");
            var input = "The quick brown fox jumps over the lazy dog.";
            var timer = new Stopwatch();
            timer.Start();
            var interpretedRegex = new Regex("(fox|dog)*");
            for (int i = 0; i < 1000000; i++)
                interpretedRegex.Match(input);
            timer.Stop();
            Console.WriteLine("\tElapsed time: {0}ms", timer.ElapsedMilliseconds);
            Console.WriteLine("\tCache size: {0}", Regex.CacheSize);

            Console.WriteLine("Compiled Regex:");
            timer.Reset();
            timer.Start();
            var compileRegex = new Regex("(fox|dog)*", RegexOptions.Compiled);
            for (int i = 0; i < 1000000; i++)
                compileRegex.Match(input);
            timer.Stop();
            Console.WriteLine("\tElapsed time: {0}ms", timer.ElapsedMilliseconds);

            Console.WriteLine("Slow Regex:");
            timer.Reset();
            timer.Start();
            Regex.IsMatch("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab", "(a+(aa)+(aaa)+(aa)+a+)+b.");
            timer.Stop();
            Console.WriteLine("\tElapsed time: {0}ms", timer.ElapsedMilliseconds);

            Console.WriteLine("Non-Capturing Regex:");
            timer.Reset();
            timer.Start();
            Regex.IsMatch("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab", "(?:a+(?:aa)+(?:aaa)+(?:aa)+a+)+b.");
            timer.Stop();
            Console.WriteLine("\tElapsed time: {0}ms", timer.ElapsedMilliseconds);

            Console.WriteLine("Lazy Regex");
            timer.Reset();
            timer.Start();
            Regex.IsMatch("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab", "a+?b.");
            timer.Stop();
            Console.WriteLine("\tElapsed time: {0}ms", timer.ElapsedMilliseconds);

            Console.WriteLine("Timed Regex:");
            var timedRegex = new Regex("(a+(aa)+(aaa)+(aa)+a+)+b.", RegexOptions.None, TimeSpan.FromSeconds(1));

            try
            {
                timedRegex.IsMatch("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab");
            }
            catch (RegexMatchTimeoutException)
            {
                Console.WriteLine("\tThe match timed out.");
            }

            Console.ReadKey();
        }
    }
}
