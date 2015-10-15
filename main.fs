open SDL2

[<EntryPoint>]
let main args =
    SDL_mixer.Mix_OpenAudio(22050, SDL_mixer.MIX_DEFAULT_FORMAT, 2, 4096)
    printfn "Hello World!"
    0
