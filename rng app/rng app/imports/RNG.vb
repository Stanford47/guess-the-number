Module RNG
    Function rng_gen()
        Randomize()

        Dim rng_number As Integer = CInt(Math.Round(100 * Rnd()))

        Return rng_number
    End Function
End Module
