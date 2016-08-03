namespace HelloWorldFSharp

open Wox.Plugin
open System
open System.Collections.Generic


type Main() =

    interface IPlugin with
        member this.Init(context) =
            ()

        member this.Query(query) =
            let list = List<Result>()
            let res = new Result()
            res.Title <- "Hello World from FSharp"
            res.SubTitle <- sprintf "Query: %s" query.Search
            res.IcoPath <- "app.png"

            list.Add(res)
            list
