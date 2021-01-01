open System
open System.IO
open System.Text

let hs = File.ReadAllLines(@"C:\Mirror\Explore\Python\HindiPUCScrapper\ch25.hi.txt")

let en = File.ReadAllLines(@"C:\Mirror\Explore\Python\HindiPUCScrapper\ch25.en.txt")

let sb = StringBuilder()

for line in 0..hs.Length-1 do

  if String.IsNullOrWhiteSpace(hs.[line]) then
    sb.AppendLine() |> ignore
  else if hs.[line] = en.[line] then
    sb.AppendLine(hs.[line]) |> ignore
  else 
    sb.AppendLine(hs.[line]) |> ignore
    if en.[line].StartsWith("Question") = false && en.[line].StartsWith("Answer") = false then
      sb.AppendLine(en.[line]) |> ignore
  
File.WriteAllText(@"C:\Mirror\Explore\Python\HindiPUCScrapper\ch25.txt", sb.ToString(), Encoding.UTF8)