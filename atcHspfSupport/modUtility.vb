Imports MapWinUtility
Imports atcUtility
Imports atcData
Imports atcUCI

Public Module Utility

    Public Function ConstituentsThatUseLast() As Generic.List(Of String)
        Static pConstituentsThatUseLast As Generic.List(Of String) = Nothing
        If pConstituentsThatUseLast Is Nothing Then
            Dim lConstituentsThatUseLastArray() As String = _
                {"BEDDEP", "RSED-BED-SAND", "RSED-BED-SILT", "RSED-BED-CLAY", "RSED-BED-TOT", "DETS", "SLDS", _
                "ABOVE-GROUND PLANT STORAGE", _
                "LITTER STORAGE", _
                "PLANT N - SURFACE LAYER STORAGE", _
                "PLANT N - UPPER PRINCIPAL STORAGE", _
                "PLANT N - LOWER LAYER STORAGE", _
                "PLANT N - ACTIVE GROUNDWATER STORAGE", _
                "PLANT N - TOTAL STORAGE", _
                "TOTAL N - TOTAL STORAGE", _
                "NH4-N SOL - SURFACE LAYER STORAGE", _
                "NH4-N SOL - UPPER PRINCIPAL STORAGE", _
                "NH4-N SOL - UPPER TRANSITORY STORAGE", _
                "NH4-N SOL - LOWER LAYER STORAGE", _
                "NH4-N SOL - ACTIVE GROUNDWATER STORAGE", _
                "NH4-N SOL - TOTAL STORAGE", _
                "NH4-N ADS - SURFACE LAYER STORAGE", _
                "NH4-N ADS - UPPER PRINCIPAL STORAGE", _
                "NH4-N ADS - UPPER TRANSITORY STORAGE", _
                "NH4-N ADS - LOWER LAYER STORAGE", _
                "NH4-N ADS - ACTIVE GROUNDWATER STORAGE", _
                "NH4-N ADS - TOTAL STORAGE", _
                "NO3/2-N - SURFACE LAYER STORAGE", _
                "NO3/2-N - UPPER PRINCIPAL STORAGE", _
                "NO3/2-N - UPPER TRANSITORY STORAGE", _
                "NO3/2-N - LOWER LAYER STORAGE", _
                "NO3/2-N - ACTIVE GROUNDWATER STORAGE", _
                "NO3/2-N - TOTAL STORAGE", _
                "SOL LABIL ORGANIC N - SURFACE LAYER STORAGE", _
                "SOL LABIL ORGANIC N - UPPER PRINCIPAL STORAGE", _
                "SOL LABIL ORGANIC N - UPPER TRANSITORY STORAGE", _
                "SOL LABIL ORGANIC N - LOWER LAYER STORAGE", _
                "SOL LABIL ORGANIC N - ACTIVE GROUNDWATER STORAGE", _
                "SOL LABIL ORGANIC N - TOTAL STORAGE", _
                "ADS LABIL ORGANIC N - SURFACE LAYER STORAGE", _
                "ADS LABIL ORGANIC N - UPPER PRINCIPAL STORAGE", _
                "ADS LABIL ORGANIC N - LOWER LAYER STORAGE", _
                "ADS LABIL ORGANIC N - ACTIVE GROUNDWATER STORAGE", _
                "ADS LABIL ORGANIC N - TOTAL STORAGE", _
                "SOL REFR ORGANIC N - SURFACE LAYER STORAGE", _
                "SOL REFR ORGANIC N - UPPER PRINCIPAL STORAGE", _
                "SOL REFR ORGANIC N - UPPER TRANSITORY STORAGE", _
                "SOL REFR ORGANIC N - LOWER LAYER STORAGE", _
                "SOL REFR ORGANIC N - ACTIVE GROUNDWATER STORAGE", _
                "SOL REFR ORGANIC N - TOTAL STORAGE", _
                "ADS REFR ORGANIC N - SURFACE LAYER STORAGE", _
                "ADS REFR ORGANIC N - UPPER PRINCIPAL STORAGE", _
                "ADS REFR ORGANIC N - LOWER LAYER STORAGE", _
                "ADS REFR ORGANIC N - ACTIVE GROUNDWATER STORAGE", _
                "ADS REFR ORGANIC N - TOTAL STORAGE"}
            pConstituentsThatUseLast = New Generic.List(Of String)(lConstituentsThatUseLastArray)
        End If
        Return pConstituentsThatUseLast
    End Function

    Friend Function ConstituentsToOutput(ByVal aType As String, _
                                Optional ByVal aCategory As Boolean = False) As atcCollection
        Dim lConstituentsToOutput As New atcCollection
        Select Case aType
            Case "Water"
                lConstituentsToOutput.Add("I:Header0", "Influx")
                lConstituentsToOutput.Add("I:SUPY", "    Rainfall")
                lConstituentsToOutput.Add("I:Header1", "Runoff")
                lConstituentsToOutput.Add("I:SURO", "    Surface ")
                lConstituentsToOutput.Add("I:Header2", "Evaporation")
                lConstituentsToOutput.Add("I:PET", "    Potential")
                lConstituentsToOutput.Add("I:IMPEV", "    Actual  ")
                lConstituentsToOutput.Add("P:Header0", "Influx")
                lConstituentsToOutput.Add("P:SUPY", "    Rainfall")
                lConstituentsToOutput.Add("P:SURLI", "    Irrigation")
                lConstituentsToOutput.Add("P:Header1", "Runoff")
                lConstituentsToOutput.Add("P:SURO", "    Surface  ")
                lConstituentsToOutput.Add("P:IFWO", "    Interflow")
                lConstituentsToOutput.Add("P:AGWO", "    Baseflow ")
                lConstituentsToOutput.Add("P:PERO", "    Total    ")
                lConstituentsToOutput.Add("P:Header2", "GW Inflow")
                lConstituentsToOutput.Add("P:IGWI", "    Deep    ")
                lConstituentsToOutput.Add("P:AGWI", "    Active  ")
                lConstituentsToOutput.Add("P:Total2", "    Total   ") 'need total of prev 2 rows
                lConstituentsToOutput.Add("P:AGWLI", "    Pumping")
                lConstituentsToOutput.Add("P:Header3", "Evaporation")
                lConstituentsToOutput.Add("P:PET", "    Potential")
                lConstituentsToOutput.Add("P:CEPE", "    Intercep St")
                lConstituentsToOutput.Add("P:UZET", "    Upper Zone")
                lConstituentsToOutput.Add("P:LZET", "    Lower Zone")
                lConstituentsToOutput.Add("P:AGWET", "    Grnd Water")
                lConstituentsToOutput.Add("P:BASET", "    Baseflow")
                lConstituentsToOutput.Add("P:TAET", "    Total   ")
                lConstituentsToOutput.Add("R:Header0", "Flow")
                lConstituentsToOutput.Add("R:ROVOL", "    OutVolume")
                If aCategory Then 'user used categories to indicate where water came from
                    lConstituentsToOutput.Add("R:ROVOL1", "    OVolPtIn")
                    lConstituentsToOutput.Add("R:ROVOL1-1", "    OVolPtInX1")
                    lConstituentsToOutput.Add("R:ROVOL1-2", "    OVolPtInX2")
                    lConstituentsToOutput.Add("R:ROVOL2", "    OVolNPIn")
                    lConstituentsToOutput.Add("R:ROVOL2-1", "    OVolNPInX1")
                    lConstituentsToOutput.Add("R:ROVOL2-2", "    OVolNPInX2")
                    lConstituentsToOutput.Add("R:ROVOL3", "    OVolPmpIn")
                    lConstituentsToOutput.Add("R:ROVOL3-1", "    OVolPmpInX1")
                    lConstituentsToOutput.Add("R:ROVOL3-2", "    OVolPmpInX2")
                    lConstituentsToOutput.Add("R:ROVOL4", "    OVolRsvIn")
                    lConstituentsToOutput.Add("R:ROVOL4-1", "    OVolRsvInX1")
                    lConstituentsToOutput.Add("R:ROVOL4-2", "    OVolRsvInX2")
                Else
                    lConstituentsToOutput.Add("R:IVOL", "     InVolume")
                End If
                lConstituentsToOutput.Add("R:PRSUPY", "    SurfPrecVol")
                lConstituentsToOutput.Add("R:VOLEV", "    SurfEvapVol")
            Case "Sediment"
                lConstituentsToOutput.Add("I:Header0", "Storage(tons/acre)")
                lConstituentsToOutput.Add("I:SLDS", "  All")
                lConstituentsToOutput.Add("I:Header1", "Washoff(tons/acre)")
                lConstituentsToOutput.Add("I:SOSLD", "  Total")

                lConstituentsToOutput.Add("P:Header0", "Storage (tons/acre)")
                lConstituentsToOutput.Add("P:DETS", "  Detached ")
                lConstituentsToOutput.Add("P:Header1", "Washoff (tons/acre)")
                lConstituentsToOutput.Add("P:SOSED", "  Total")

                lConstituentsToOutput.Add("R:BEDDEP", "Bed Depth (ft)")
                lConstituentsToOutput.Add("R:Header0", "Bed Storage (tons)")
                lConstituentsToOutput.Add("R:RSED-BED-SAND", "  Sand")
                lConstituentsToOutput.Add("R:RSED-BED-SILT", "  Silt")
                lConstituentsToOutput.Add("R:RSED-BED-CLAY", "  Clay")
                lConstituentsToOutput.Add("R:RSED-BED-TOT", "  Total")
                lConstituentsToOutput.Add("R:Header1", "Inflow (tons)")
                lConstituentsToOutput.Add("R:ISED-SAND", "  Sand")
                lConstituentsToOutput.Add("R:ISED-SILT", "  Silt")
                lConstituentsToOutput.Add("R:ISED-CLAY", "  Clay")
                lConstituentsToOutput.Add("R:ISED-TOT", "  Total")
                lConstituentsToOutput.Add("R:Header2", "Dep(+)/Scour(-) (tons)")
                lConstituentsToOutput.Add("R:DEPSCOUR-SAND", "  Sand")
                lConstituentsToOutput.Add("R:DEPSCOUR-SILT", "  Silt")
                lConstituentsToOutput.Add("R:DEPSCOUR-CLAY", "  Clay")
                lConstituentsToOutput.Add("R:DEPSCOUR-TOT", "  Total")
                lConstituentsToOutput.Add("R:Header3", "Outflow (tons)")
                lConstituentsToOutput.Add("R:ROSED-SAND", "  Sand")
                lConstituentsToOutput.Add("R:ROSED-SILT", "  Silt")
                lConstituentsToOutput.Add("R:ROSED-CLAY", "  Clay")
                lConstituentsToOutput.Add("R:ROSED-TOT", "  Total")
            Case "SedimentCopper"
                lConstituentsToOutput.Add("I:SOSLD", "Solids   ")
                lConstituentsToOutput.Add("I:SOQUAL-Copper", "Copper   ")
                lConstituentsToOutput.Add("I:SOQS-Copper", "Sed-Assoc Cu")
                lConstituentsToOutput.Add("I:SOQO-Copper", "Flow-Assoc Cu")
                lConstituentsToOutput.Add("P:SOSED", "Sediment")
                lConstituentsToOutput.Add("P:SOQUAL-Copper", "  Surface Cu")
                lConstituentsToOutput.Add("P:IOQUAL-Copper", "  Interflow Cu")
                lConstituentsToOutput.Add("P:AOQUAL-Copper", "  Groundwater Cu")
                lConstituentsToOutput.Add("P:SOQS-Copper", "Sed-Assoc Cu")
                lConstituentsToOutput.Add("P:SOQO-Copper", "Flow-Assoc Cu")
                lConstituentsToOutput.Add("P:POQUAL-Copper", "Total Cu")
                lConstituentsToOutput.Add("R:ROSED-SAND", "  Sand")
                lConstituentsToOutput.Add("R:ROSED-SILT", "  Silt")
                lConstituentsToOutput.Add("R:ROSED-CLAY", "  Clay")
                lConstituentsToOutput.Add("R:ROSED-TOT", "Total Sediment")
                lConstituentsToOutput.Add("R:Copper-RODQAL", "Disolved Cu")
                lConstituentsToOutput.Add("R:Copper-ROSQAL-SAND", "  Sand Cu")
                lConstituentsToOutput.Add("R:Copper-ROSQAL-SILT", "  Silt Cu")
                lConstituentsToOutput.Add("R:Copper-ROSQAL-CLAY", "  Clay Cu")
                lConstituentsToOutput.Add("R:Copper-ROSQAL-Tot", "Total Sediment Cu")
                lConstituentsToOutput.Add("R:Copper-TROQAL", "Total Cu")
            Case "FColi"
                lConstituentsToOutput.Add("P:Header1", "Perv Load")
                lConstituentsToOutput.Add("P:SOQUAL-F.Coliform", "Surface")
                lConstituentsToOutput.Add("P:IOQUAL-F.Coliform", "Interflow")
                lConstituentsToOutput.Add("P:AOQUAL-F.Coliform", "Baseflow")
                lConstituentsToOutput.Add("P:POQUAL-F.Coliform", "Total")
                lConstituentsToOutput.Add("I:Header2", "Imperv Load")
                lConstituentsToOutput.Add("I:SOQUAL-F.Coliform", "ImpervSurf")
                lConstituentsToOutput.Add("R:Header3", "Instream")
                lConstituentsToOutput.Add("R:F.Coliform-TIQAL", "  Inflow")
                lConstituentsToOutput.Add("R:F.Coliform-DDQAL-TOT", "  Decay")
                lConstituentsToOutput.Add("R:F.Coliform-TROQAL", "  Outflow")
            Case "N-PQUAL"
                lConstituentsToOutput.Add("P:Header1", "NH3+NH4 (lb/ac)")
                lConstituentsToOutput.Add("P:WASHQS-NH3+NH4", "WASHQS")
                lConstituentsToOutput.Add("P:SOQUAL-NH3+NH4", "SOQUAL")
                lConstituentsToOutput.Add("P:IOQUAL-NH3+NH4", "IOQUAL")
                lConstituentsToOutput.Add("P:AOQUAL-NH3+NH4", "AOQUAL")
                lConstituentsToOutput.Add("P:POQUAL-NH3+NH4", "POQUAL")
                lConstituentsToOutput.Add("P:Header2", "NO3 (lb/ac)")
                lConstituentsToOutput.Add("P:WASHQS-NO3", "WASHQS")
                lConstituentsToOutput.Add("P:SOQUAL-NO3", "SOQUAL")
                lConstituentsToOutput.Add("P:IOQUAL-NO3", "IOQUAL")
                lConstituentsToOutput.Add("P:AOQUAL-NO3", "AOQUAL")
                lConstituentsToOutput.Add("P:POQUAL-NO3", "POQUAL")
                lConstituentsToOutput.Add("I:Header3", "NH3+NH4 (lb/ac)")
                lConstituentsToOutput.Add("I:SOQUAL-NH3+NH4", "SOQUAL")
                lConstituentsToOutput.Add("I:Header4", "NO3 (lb/ac)")
                lConstituentsToOutput.Add("I:SOQUAL-NO3", "SOQUAL")
                lConstituentsToOutput.Add("R:Header4", "Totals")
                lConstituentsToOutput.Add("R:N-TOT-IN", "  N-TOT-IN")
                lConstituentsToOutput.Add("R:N-TOT-OUT", "  N-TOT-OUT")
            Case "P-PQUAL"
                lConstituentsToOutput.Add("P:Header1", "Ortho P (lb/ac)")
                lConstituentsToOutput.Add("P:WASHQS-ORTHO P", "WASHQS")
                lConstituentsToOutput.Add("P:SOQUAL-ORTHO P", "SOQUAL")
                lConstituentsToOutput.Add("P:IOQUAL-ORTHO P", "IOQUAL")
                lConstituentsToOutput.Add("P:AOQUAL-ORTHO P", "AOQUAL")
                lConstituentsToOutput.Add("P:POQUAL-ORTHO P", "POQUAL")
                lConstituentsToOutput.Add("I:Header2", "Ortho P (lb/ac)")
                lConstituentsToOutput.Add("I:SOQUAL-ORTHO P", "SOQUAL")
                lConstituentsToOutput.Add("R:Header3", "Totals")
                lConstituentsToOutput.Add("R:P-TOT-IN", "  P-TOT-IN")
                lConstituentsToOutput.Add("R:P-TOT-OUT", "  P-TOT-OUT")
            Case "TotalN" 'use PQUAL
                With lConstituentsToOutput
                    .Add("P:Header1", "Nutrient Loss (lb/a)")
                    .Add("P:Header1a", "  NO3 Loss")
                    .Add("P:NO3+NO2-N - SURFACE LAYER OUTFLOW", "    Surface")
                    .Add("P:NO3+NO2-N - UPPER LAYER OUTFLOW", "    Interflow")
                    .Add("P:NO3+NO2-N - GROUNDWATER OUTFLOW", "    Baseflow")
                    .Add("P:NO3-N - TOTAL OUTFLOW", "    Total")
                    .Add("P:Header1b", "  NH3 Loss")
                    .Add("P:NH4-N IN SOLUTION - SURFACE LAYER OUTFLOW", "    Surface")
                    .Add("P:NH4-N IN SOLUTION - UPPER LAYER OUTFLOW", "    Interflow")
                    .Add("P:NH4-N IN SOLUTION - GROUNDWATER OUTFLOW", "    Baseflow")
                    .Add("P:NH4-N ADS - SEDIMENT ASSOC OUTFLOW", "    Sediment")
                    .Add("P:NH4-N - TOTAL OUTFLOW", "    Total")
                    .Add("P:Header1c", "  Labile ORGN Loss")
                    .Add("P:LABILE ORGN - SURFACE LAYER OUTFLOW", "    Surface")
                    .Add("P:LABILE ORGN - UPPER LAYER OUTFLOW", "    Interflow")
                    .Add("P:LABILE ORGN - GROUNDWATER OUTFLOW", "    Baseflow")
                    .Add("P:LABILE ORGN - SEDIMENT ASSOC OUTFLOW", "    Sediment")
                    .Add("P:Header1d", "  Refractory ORGN Loss")
                    .Add("P:REFRAC ORGN - SURFACE LAYER OUTFLOW", "    Surface")
                    .Add("P:REFRAC ORGN - UPPER LAYER OUTFLOW", "    Interflow")
                    .Add("P:REFRAC ORGN - GROUNDWATER OUTFLOW", "    Baseflow")
                    .Add("P:REFRAC ORGN - SEDIMENT ASSOC OUTFLOW", "    Sediment")
                    .Add("P:ORGN - TOTAL OUTFLOW", "  Total ORGN Loss")
                    .Add("P:NITROGEN - TOTAL OUTFLOW", "  Total N Loss")

                    .Add("P:Header2", "STORAGES (lb/ac)")
                    .Add("P:ABOVE-GROUND PLANT STORAGE", "Above Ground Plant N")
                    .Add("P:LITTER STORAGE", "Litter N")
                    .Add("P:Header2a", "Below Ground Plant N")
                    .Add("P:PLANT N - SURFACE LAYER STORAGE", "Surface")
                    .Add("P:PLANT N - UPPER PRINCIPAL STORAGE", "Upper")
                    .Add("P:PLANT N - LOWER LAYER STORAGE", "Lower")
                    .Add("P:PLANT N - ACTIVE GROUNDWATER STORAGE", "GW")
                    .Add("P:PLANT N - TOTAL STORAGE", "Total AG, BG, Litter PLTN")
                    .Add("P:TOTAL N - TOTAL STORAGE", "Total Soil, Litter, & Plant N")
                    .Add("P:Header2b", "NH4-N Soln Storage")
                    .Add("P:NH4-N SOL - SURFACE LAYER STORAGE", "Surface")
                    .Add("P:NH4-N SOL - UPPER PRINCIPAL STORAGE", "Upper")
                    .Add("P:NH4-N SOL - UPPER TRANSITORY STORAGE", "Interflow")
                    .Add("P:NH4-N SOL - LOWER LAYER STORAGE", "Lower")
                    .Add("P:NH4-N SOL - ACTIVE GROUNDWATER STORAGE", "GW")
                    .Add("P:NH4-N SOL - TOTAL STORAGE", "Total")
                    .Add("P:Header2c", "NH4-N Ads Storage")
                    .Add("P:NH4-N ADS - SURFACE LAYER STORAGE", "Surface")
                    .Add("P:NH4-N ADS - UPPER PRINCIPAL STORAGE", "Upper")
                    .Add("P:NH4-N ADS - UPPER TRANSITORY STORAGE", "Interflow")
                    .Add("P:NH4-N ADS - LOWER LAYER STORAGE", "Lower")
                    .Add("P:NH4-N ADS - ACTIVE GROUNDWATER STORAGE", "GW")
                    .Add("P:NH4-N ADS - TOTAL STORAGE", "Total")
                    .Add("P:Header2d", "NO3/2-N Storage")
                    .Add("P:NO3/2-N - SURFACE LAYER STORAGE", "Surface")
                    .Add("P:NO3/2-N - UPPER PRINCIPAL STORAGE", "Upper")
                    .Add("P:NO3/2-N - UPPER TRANSITORY STORAGE", "Interflow")
                    .Add("P:NO3/2-N - LOWER LAYER STORAGE", "Lower")
                    .Add("P:NO3/2-N - ACTIVE GROUNDWATER STORAGE", "GW")
                    .Add("P:NO3/2-N - TOTAL STORAGE", "Total")
                    .Add("P:Header2e", "Labile ORGN Soln")
                    .Add("P:SOL LABIL ORGANIC N - SURFACE LAYER STORAGE", "Surface")
                    .Add("P:SOL LABIL ORGANIC N - UPPER PRINCIPAL STORAGE", "Upper")
                    .Add("P:SOL LABIL ORGANIC N - UPPER TRANSITORY STORAGE", "Interflow")
                    .Add("P:SOL LABIL ORGANIC N - LOWER LAYER STORAGE", "Lower")
                    .Add("P:SOL LABIL ORGANIC N - ACTIVE GROUNDWATER STORAGE", "GW")
                    .Add("P:SOL LABIL ORGANIC N - TOTAL STORAGE", "Total")
                    .Add("P:Header2f", "Labile ORGN Ads")
                    .Add("P:ADS LABIL ORGANIC N - SURFACE LAYER STORAGE", "Surface")
                    .Add("P:ADS LABIL ORGANIC N - UPPER PRINCIPAL STORAGE", "Upper")
                    .Add("P:ADS LABIL ORGANIC N - LOWER LAYER STORAGE", "Lower")
                    .Add("P:ADS LABIL ORGANIC N - ACTIVE GROUNDWATER STORAGE", "GW")
                    .Add("P:ADS LABIL ORGANIC N - TOTAL STORAGE", "Total")
                    .Add("P:Header2g", "Refractory ORGN Soln")
                    .Add("P:SOL REFR ORGANIC N - SURFACE LAYER STORAGE", "Surface")
                    .Add("P:SOL REFR ORGANIC N - UPPER PRINCIPAL STORAGE", "Upper")
                    .Add("P:SOL REFR ORGANIC N - UPPER TRANSITORY STORAGE", "Interflow")
                    .Add("P:SOL REFR ORGANIC N - LOWER LAYER STORAGE", "Lower")
                    .Add("P:SOL REFR ORGANIC N - ACTIVE GROUNDWATER STORAGE", "GW")
                    .Add("P:SOL REFR ORGANIC N - TOTAL STORAGE", "Total")
                    .Add("P:Header2h", "Refractory ORGN Ads")
                    .Add("P:ADS REFR ORGANIC N - SURFACE LAYER STORAGE", "Surface")
                    .Add("P:ADS REFR ORGANIC N - UPPER PRINCIPAL STORAGE", "Upper")
                    .Add("P:ADS REFR ORGANIC N - LOWER LAYER STORAGE", "Lower")
                    .Add("P:ADS REFR ORGANIC N - ACTIVE GROUNDWATER STORAGE", "GW")
                    .Add("P:ADS REFR ORGANIC N - TOTAL STORAGE", "Total")

                    .Add("P:Header3", "FLUXES")
                    .Add("P:NH4-N - SURFACE LAYER - TOTAL AD", "NH3-N - SURFACE")
                    .Add("P:NO3-N - SURFACE LAYER - TOTAL AD", "NO3-N - SURFACE")
                    .Add("P:ORGN - SURFACE LAYER - TOTAL AD", "ORGN - SURFACE")
                    .Add("P:NH4-N - UPPER LAYER - TOTAL AD", "NH3-N - UPPER")
                    .Add("P:NO3-N - UPPER LAYER - TOTAL AD", "NO3-N - UPPER")
                    .Add("P:ORGN - UPPER LAYER - TOTAL AD", "ORGN - UPPER")
                    '.Add("P:add these up to get a total of each species ?", "")
                    .Add("P:Header3a", "Applications (lb/a)")
                    .Add("P:AMMONIA APPLICATION", "    NH3-N")
                    .Add("P:NITRATE APPLICATION", "    NO3-N")
                    .Add("P:ORGANIC N APPLICATION", "    ORGN")
                    .Add("P:Header3b", "Above Ground Plant Uptake")
                    .Add("P:TAMUPA", "    NH3-N")
                    .Add("P:TNIUPA", "    NO3-N")
                    .Add("P:Header3c", "Below Ground Plant Uptake")
                    .Add("P:TAMUPB", "    NH3-N")
                    .Add("P:TNIUPB", "    NO3-N")
                    .Add("P:RETAGN", "Above Gr Plant N to Litter")
                    .Add("P:Header3d", "Litter N Return to Labile ORGN")
                    .Add("P:SRTLLN", "    Surface")
                    .Add("P:URTLLN", "    Upper")
                    .Add("P:TRTLLN", "    Total")
                    .Add("P:Header3e", "Litter N Return to Refractory ORGN")
                    .Add("P:SRTRLN", "    Surface")
                    .Add("P:URTRLN", "    Upper")
                    .Add("P:TRTRLN", "    Total")
                    .Add("P:Header3f", "BG Plant N Return to Labile ORGN")
                    .Add("P:SRTLBN", "    Surface")
                    .Add("P:URTLBN", "    Upper")
                    .Add("P:LRTLBN", "    Lower")
                    .Add("P:TRTLBN", "    Total")
                    .Add("P:Header3g", "BG Plant N Return to Refractory ORGN")
                    .Add("P:SRTRBN", "    Surface")
                    .Add("P:URTRBN", "    Upper")
                    .Add("P:LRTRBN", "    Lower")
                    .Add("P:TRTRBN", "    Total")
                    .Add("P:TREFON", "Labile/Refractory ORGN Conversion")
                    .Add("P:TORNMN", "Labile ORGN Mineralization")
                    .Add("P:TDENI", "Denitrification")
                    .Add("P:TAMNIT", "NH3 Nitrification")
                    .Add("P:TAMIMB", "NH3 Immobilization")
                    .Add("P:TNIIMB", "NO3 Immobilization")

                
                    .Add("P:Header4", "NH3+NH4")
                .Add("P:WASHQS-NH3+NH4", "  WASHQS")
                .Add("P:SOQUAL-NH3+NH4", "  SOQUAL")
                .Add("P:IOQUAL-NH3+NH4", "  IOQUAL")
                .Add("P:AOQUAL-NH3+NH4", "  AOQUAL")
                .Add("P:POQUAL-NH3+NH4", "  POQUAL")
                    .Add("P:Header5", "NO3")
                .Add("P:WASHQS-NO3", "  WASHQS")
                .Add("P:SOQUAL-NO3", "  SOQUAL")
                .Add("P:IOQUAL-NO3", "  IOQUAL")
                .Add("P:AOQUAL-NO3", "  AOQUAL")
                .Add("P:POQUAL-NO3", "  POQUAL")

                    .Add("P:Header6", "RefOrgN")
                .Add("P:WASHQS-BOD1", "  WASHQS")
                .Add("P:SOQUAL-BOD1", "  SOQUAL")
                .Add("P:IOQUAL-BOD1", "  IOQUAL")
                .Add("P:AOQUAL-BOD1", "  AOQUAL")
                .Add("P:POQUAL-BOD1", "  POQUAL")

                    .Add("P:Header7", "LabileOrgN")
                .Add("P:WASHQS-BOD2", "  WASHQS")
                .Add("P:SOQUAL-BOD2", "  SOQUAL")
                .Add("P:IOQUAL-BOD2", "  IOQUAL")
                .Add("P:AOQUAL-BOD2", "  AOQUAL")
                .Add("P:POQUAL-BOD2", "  POQUAL")

                    .Add("I:Header8", "NH3+NH4")
                .Add("I:SOQUAL-NH3+NH4", "  SOQUAL")
                    .Add("I:Header9", "NO3")
                .Add("I:SOQUAL-NO3", "  SOQUAL")

                    .Add("I:Header10", "RefOrgN")
                .Add("I:SOQUAL-BOD1", "  SOQUAL")

                    .Add("I:Header11", "LabileOrgN")
                .Add("I:SOQUAL-BOD2", "  SOQUAL")

                    .Add("R:Header12", "TAM-N")
                .Add("R:TAM-INTOT", "  TAM-INTOT")
                .Add("R:TAM-INDIS", "  TAM-INDIS")
                .Add("R:NH4-INPART-TOT", "  NH4-INPART-TOT")
                .Add("R:TAM-PROCFLUX-TOT", "  TAM-PROCFLUX-TOT")
                .Add("R:TAM-OUTTOT", "  TAM-OUTTOT")
                .Add("R:TAM-OUTDIS", "  TAM-OUTDIS")
                .Add("R:TAM-OUTPART-TOT", "  TAM-OUTPART-TOT")
                .Add("R:TAM-OUTTOT-EXIT3", "  TAM-OUTTOT-EXIT3")
                .Add("R:TAM-OUTDIS-EXIT3", "  TAM-OUTDIS-EXIT3")
                .Add("R:TAM-OUTPART-TOT-EXIT3", "  TAM-OUTPART-TOT-EXIT3")

                    .Add("R:Header13", "NO3-N")
                .Add("R:NO3-INTOT", "  NO3-INTOT")
                .Add("R:NO3-PROCFLUX-TOT", "  NO3-PROCFLUX-TOT")
                .Add("R:NO3-OUTTOT", "  NO3-OUTTOT")
                .Add("R:NO3-OUTTOT-EXIT3", "  NO3-OUTTOT-EXIT3")

                    .Add("R:Header14", "ORGN-N")
                .Add("R:N-TOTORG-IN", "  N-TOTORG-IN")
                .Add("R:N-TOTORG-OUT", "  N-TOTORG-OUT")

                    .Add("R:Header15", "REFORG-N")
                .Add("R:N-REFORG-IN", "  N-REFORG-IN")
                .Add("R:N-REFORG-TOTPROCFLUX-TOT", "  N-REFORG-TOTPROCFLUX-TOT")
                .Add("R:N-REFORG-OUT", "  N-REFORG-OUT")

                    .Add("R:Header16", "Totals")
                .Add("R:N-TOT-IN", "  N-TOT-IN")
                .Add("R:N-TOT-OUT", "  N-TOT-OUT")
              End With

                'lConstituentsToOutput.Add("R:N-TOT-OUT-EXIT1", "  N-TOT-OUT-EXIT1")
                'lConstituentsToOutput.Add("R:N-TOT-OUT-EXIT2", "  N-TOT-OUT-EXIT2")
                'lConstituentsToOutput.Add("R:N-TOT-OUT-EXIT3", "  N-TOT-OUT-EXIT3")
            Case "TotalP"
                lConstituentsToOutput.Add("P:Header1", "Ortho P")
                lConstituentsToOutput.Add("P:SOQUAL-Ortho P", "  SOQUAL")
                lConstituentsToOutput.Add("P:IOQUAL-Ortho P", "  IOQUAL")
                lConstituentsToOutput.Add("P:AOQUAL-Ortho P", "  AOQUAL")
                lConstituentsToOutput.Add("P:POQUAL-Ortho P", "  POQUAL")

                lConstituentsToOutput.Add("P:Header3", "RefOrgP")
                lConstituentsToOutput.Add("P:WASHQS-BOD1", "  WASHQS")
                lConstituentsToOutput.Add("P:SOQUAL-BOD1", "  SOQUAL")
                lConstituentsToOutput.Add("P:IOQUAL-BOD1", "  IOQUAL")
                lConstituentsToOutput.Add("P:AOQUAL-BOD1", "  AOQUAL")
                lConstituentsToOutput.Add("P:POQUAL-BOD1", "  POQUAL")

                lConstituentsToOutput.Add("P:Header4", "LabileOrgP")
                lConstituentsToOutput.Add("P:WASHQS-BOD2", "  WASHQS")
                lConstituentsToOutput.Add("P:SOQUAL-BOD2", "  SOQUAL")
                lConstituentsToOutput.Add("P:IOQUAL-BOD2", "  IOQUAL")
                lConstituentsToOutput.Add("P:AOQUAL-BOD2", "  AOQUAL")
                lConstituentsToOutput.Add("P:POQUAL-BOD2", "  POQUAL")

                lConstituentsToOutput.Add("I:Header5", "Ortho P")
                lConstituentsToOutput.Add("I:SOQUAL-Ortho P", "  SOQUAL")

                lConstituentsToOutput.Add("I:Header7", "RefOrgP")
                lConstituentsToOutput.Add("I:SOQUAL-BOD1", "  SOQUAL")

                lConstituentsToOutput.Add("I:Header8", "LabileOrgP")
                lConstituentsToOutput.Add("I:SOQUAL-BOD2", "  SOQUAL")

                lConstituentsToOutput.Add("R:Header11", "PO4")
                lConstituentsToOutput.Add("R:PO4-INTOT", "  PO4-INTOT")
                lConstituentsToOutput.Add("R:PO4-INDIS", "  PO4-INDIS")
                lConstituentsToOutput.Add("R:PO4-INPART-TOT", "  PO4-INPART-TOT")
                lConstituentsToOutput.Add("R:PO4-PROCFLUX-TOT", "  PO4-PROCFLUX-TOT")
                lConstituentsToOutput.Add("R:PO4-OUTTOT", "  PO4-OUTTOT")
                lConstituentsToOutput.Add("R:PO4-OUTDIS", "  PO4-OUTDIS")
                lConstituentsToOutput.Add("R:PO4-OUTPART-TOT", "  PO4-OUTPART-TOT")

                lConstituentsToOutput.Add("R:Header13", "ORGN-P")
                lConstituentsToOutput.Add("R:P-TOTORG-IN", "  P-TOTORG-IN")
                lConstituentsToOutput.Add("R:P-TOTORG-OUT", "  P-TOTORG-OUT")

                lConstituentsToOutput.Add("R:Header14", "REFORG-N")
                lConstituentsToOutput.Add("R:P-REFORG-IN", "  P-REFORG-IN")
                lConstituentsToOutput.Add("R:P-REFORG-TOTPROCFLUX-TOT", "  P-REFORG-TOTPROCFLUX-TOT")
                lConstituentsToOutput.Add("R:P-REFORG-OUT", "  P-REFORG-OUT")

                lConstituentsToOutput.Add("R:Header15", "Totals")
                lConstituentsToOutput.Add("R:P-TOT-IN", "  P-TOT-IN")
                lConstituentsToOutput.Add("R:P-TOT-OUT", "  P-TOT-OUT")
            Case ("BOD-PQUAL")
                lConstituentsToOutput.Add("P:Header1", "BOD")
                lConstituentsToOutput.Add("P:WASHQS-BOD", "  WASHQS")
                lConstituentsToOutput.Add("P:SOQUAL-BOD", "  SOQUAL")
                lConstituentsToOutput.Add("P:IOQUAL-BOD", "  IOQUAL")
                lConstituentsToOutput.Add("P:AOQUAL-BOD", "  AOQUAL")
                lConstituentsToOutput.Add("P:POQUAL-BOD", "  POQUAL")

                lConstituentsToOutput.Add("I:Header2", "BOD")
                lConstituentsToOutput.Add("I:SOQUAL-BOD", "  SOQUAL")

                lConstituentsToOutput.Add("R:Header3", "BOD")
                lConstituentsToOutput.Add("R:BODIN", "  BODIN")
                lConstituentsToOutput.Add("R:BODFLUX-BODDEC", "  BODFLUX-BODDEC")
                lConstituentsToOutput.Add("R:BODFLUX-SINK", "  BODFLUX-SINK")
                lConstituentsToOutput.Add("R:BODFLUX-BENTHAL", "  BODFLUX-BENTHAL")
                lConstituentsToOutput.Add("R:BODFLUX-PHYTO", "  BODFLUX-PHYTO")
                lConstituentsToOutput.Add("R:BODFLUX-ZOO", "  R:BODFLUX-ZOO")
                lConstituentsToOutput.Add("R:BODFLUX-BENTHIC", "  BODFLUX-BENTHIC")
                lConstituentsToOutput.Add("R:BODOUTTOT", "  BODOUTTOT")

        End Select
        Return lConstituentsToOutput
    End Function

    Public Function LandUses(ByVal aUci As HspfUci, _
                             ByVal aOperationTypes As atcCollection, _
                    Optional ByVal aOutletLocation As String = "") As atcCollection
        Dim lLocations As New atcCollection
        If aOutletLocation.Length > 0 Then
            lLocations = UpstreamLocations(aUci, aOperationTypes, aOutletLocation)
        End If
        Dim lLandUsesSortedById As New SortedList
        Dim lLandUses As New atcCollection
        Dim lOperations As atcCollection
        For lOperationIndex As Integer = 0 To aUci.OpnSeqBlock.Opns.Count - 1
            Dim lOperation As atcUCI.HspfOperation = aUci.OpnSeqBlock.Opns(lOperationIndex)
            Dim lLocationKey As String = lOperation.Name.Substring(0, 1) & ":" & lOperation.Id
            If lLocations.Count = 0 OrElse lLocations.IndexFromKey(lLocationKey) >= 0 Then
                Dim lLandUse As String = lOperation.Name.Substring(0, 1) & ":"
                Dim lDecsriptonParts() As String = lOperation.Description.Split(" ")
                For lIndex As Integer = 0 To lDecsriptonParts.GetUpperBound(0)
                    If Not IsNumeric(lDecsriptonParts(lIndex)) Then
                        lLandUse &= lDecsriptonParts(lIndex) & " "
                    End If
                Next
                lLandUse = lLandUse.Trim(" ")
                Dim lOperationKey As String = lOperation.Name.Substring(0, 1) & ":" & lOperation.Id
                Dim lOperationArea As Double = 0.0
                If aOutletLocation.Length > 0 Then
                    lOperationArea = lLocations.ItemByKey(lLocationKey)
                End If
                Dim lLandUseKeyIndex As Integer = lLandUses.IndexFromKey(lLandUse)
                If lLandUseKeyIndex = -1 Then
                    lOperations = New atcCollection
                    lOperations.Add(lOperationKey, lOperationArea) 'e.g. R:116 0.0
                    Dim lOperationId As String = lOperation.Id.ToString
                    If lOperationId.Length = 1 Then lOperationId = Format(lOperation.Id Mod 100, "00")
                    'Becky had a concern about this, but her code seems functionally the same
                    Dim lId As String = lLocationKey.Substring(0, 2) & lOperationId
                    If lLandUsesSortedById.IndexOfKey(lId) = -1 Then
                        lLandUsesSortedById.Add(lId, lLandUse)
                    End If
                    lLandUses.Add(lLandUse, lOperations)
                Else
                    lOperations = lLandUses.Item(lLandUseKeyIndex)
                    lOperations.Add(lOperationKey, lOperationArea)
                    'For Debug
                    'lLandUses.Keys -> lLandUses.ItemByKey(lu).Keys -> "R:69"
                End If
            End If
        Next
        Dim lLandUsesTemp As New atcCollection
        For Each lLandUseKey As String In lLandUsesSortedById.Keys
            Dim lKey As String = lLandUsesSortedById.Item(lLandUseKey)
            lLandUsesTemp.Add(lKey, lLandUses.ItemByKey(lKey))
        Next
        Return lLandUsesTemp
    End Function

    Public Function UpstreamLocations(ByVal aUci As HspfUci, _
                                      ByVal aOperationTypes As atcCollection, _
                                      ByVal aLocation As String) As atcCollection
        Dim lLocations As New atcCollection 'key-location, value-total area
        UpstreamLocationAreaCalc(aUci, aLocation, aOperationTypes, lLocations)
        Return lLocations
    End Function

    Private Sub UpstreamLocationAreaCalc(ByVal aUci As HspfUci, _
                                         ByVal aLocation As String, _
                                         ByVal aOperationTypes As atcCollection, _
                                         ByRef aLocations As atcCollection)
        LocationAreaCalc(aUci, aLocation, aOperationTypes, aLocations, True)
    End Sub

    Public Sub LocationAreaCalc(ByVal aUci As HspfUci, _
                                ByVal aLocation As String, _
                                ByVal aOperationTypes As atcCollection, _
                                ByRef aLocations As atcCollection, _
                                ByVal aUpstream As Boolean)
        Dim lOperName As String = aOperationTypes.ItemByKey(aLocation.Substring(0, 2))
        Dim lOperation As HspfOperation = aUci.OpnBlks(lOperName).OperFromID(aLocation.Substring(2))
        If Not lOperation Is Nothing Then
            Dim lUpstreamChecked As New atcCollection
            For Each lConnection As HspfConnection In lOperation.Sources
                Dim lSourceVolName As String = lConnection.Source.VolName
                Dim lLocationKey As String = lSourceVolName.Substring(0, 1) & ":" & lConnection.Source.VolId
                If lSourceVolName = "PERLND" Or lSourceVolName = "IMPLND" Then
                    If lConnection.MFact > 0 Then
                        aLocations.Increment(lLocationKey, lConnection.MFact)
                    End If
                ElseIf lSourceVolName = "RCHRES" Then
                    If aUpstream Then
                        If lUpstreamChecked.Contains(lLocationKey) Then
                            Logger.Dbg("SkipDuplicate:" & lLocationKey)
                        ElseIf aUci.Name.ToLower.Contains("scr") AndAlso _
                               lConnection.Source.VolId = 229 AndAlso _
                               lConnection.Target.VolId = 516 Then
                            'TODO: figure out a way not to hardcode this!
                            Logger.Dbg("Skip 229 to 516 in SantaClara")
                        Else
                            LocationAreaCalc(aUci, lLocationKey, aOperationTypes, aLocations, True)
                            lUpstreamChecked.Add(lLocationKey)
                        End If
                    Else
                        aLocations.Add(lLocationKey, 0)
                    End If
                End If
            Next
        End If

        'For Debug:
        'Detect if the final outlet is included
        'If aLocation = "R:69" Then
        aLocations.Add(aLocation, 0.0)
    End Sub

    'Compute total area of an implnd or perlnd by totaling all MFact of connections from it
    Friend Function OperationArea(ByVal aUci As HspfUci, ByVal aOperation As HspfOperation) As Double
        Dim lArea As Double = 0
        For Each lReach As HspfOperation In aUci.OpnBlks("RCHRES").Ids
            For Each lConnection As HspfConnection In lReach.Sources
                If Not lConnection.Source.Opn Is Nothing AndAlso lConnection.Source.Opn.Equals(aOperation) Then
                    lArea += lConnection.MFact
                End If
            Next
        Next
        Return lArea
    End Function

    Public Function CfsToInches(ByVal aTSerIn As atcTimeseries, _
                                ByVal aArea As Double) As atcTimeseries
        Dim lConversionFactor As Double = (12.0# * 24.0# * 3600.0#) / (aArea * 43560.0#)   'cfs days to inches
        Dim lTsMath As atcTimeseriesSource = New atcTimeseriesMath.atcTimeseriesMath
        Dim lArgsMath As New atcDataAttributes
        lArgsMath.SetValue("timeseries", aTSerIn)
        lArgsMath.SetValue("number", lConversionFactor)
        lTsMath.Open("multiply", lArgsMath)
        Return lTsMath.DataSets(0)
    End Function

    Public Function InchesToCfs(ByVal aTSerIn As atcTimeseries, _
                                ByVal aArea As Double) As atcTimeseries
        Dim lConversionFactor As Double = (aArea * 43560.0#) / (12.0# * 24.0# * 3600.0#) 'inches to cfs days
        Dim lInterval As Double = aTSerIn.Attributes.GetValue("interval", 1.0)
        lConversionFactor /= lInterval
        Dim lTsMath As atcTimeseriesSource = New atcTimeseriesMath.atcTimeseriesMath
        Dim lArgsMath As New atcDataAttributes
        lArgsMath.SetValue("timeseries", aTSerIn)
        lArgsMath.SetValue("number", lConversionFactor)
        lTsMath.Open("multiply", lArgsMath)
        Return lTsMath.DataSets(0)
    End Function

    Friend Sub CheckDateJ(ByVal aTSer As atcTimeseries, _
                          ByVal aName As String, _
                          ByRef aSDateJ As Double, _
                          ByRef aEDateJ As Double, _
                          ByRef aStr As String)
        Dim lDateTmp As Double = aTSer.Dates.Values(0)
        If aSDateJ < lDateTmp Then
            aStr &= "   Adjusted Start Date from " & Format(Date.FromOADate(aSDateJ), "yyyy/MM/dd") & _
                                             "to " & Format(Date.FromOADate(lDateTmp), "yyyy/MM/dd") & _
                                        " due to " & aName & vbCrLf & vbCrLf
            aSDateJ = lDateTmp
        End If
        lDateTmp = aTSer.Dates.Values(aTSer.numValues)
        If aEDateJ > lDateTmp Then
            aStr &= "   Adjusted End Date from " & Format(Date.FromOADate(aEDateJ), "yyyy/MM/dd") & _
                                          " to " & Format(Date.FromOADate(lDateTmp), "yyyy/MM/dd") & _
                                      " due to " & aName & vbCrLf & vbCrLf
            aEDateJ = lDateTmp
        End If
    End Sub

    Public Function AreaReport(ByVal aUci As HspfUci, ByVal aRunMade As String, _
                               ByVal aOperationTypes As atcCollection, ByVal aLocations As atcCollection, _
                               ByVal aLandUseReport As Boolean, ByVal aReportPath As String) As atcReport.IReport
        Dim lReport As New atcReport.ReportText
        lReport.AppendLine("Area Summary Report")
        lReport.AppendLine("   UCI File Name " & aUci.Name)
        lReport.AppendLine("   Run Made " & aRunMade)
        lReport.AppendLine("   " & aUci.GlobalBlock.RunInf.Value)
        lReport.AppendLine("")

        lReport.AppendLine("Location" & vbTab & "TotalArea".PadLeft(12) & vbTab & "LocalArea".PadLeft(12) & vbTab & "UpstreamReaches")
        'Becky changed the following to cycle through all locations
        'Dim lLocation As String = aLocations.Item(aLocations.Count - 1)
        For Each lLocation As String In aLocations 'added by Becky - should force land use reports for ALL relevant reaches 
            'and also add the total for all relevant reaches to a single overall report
            lReport.AppendLine(AreaReportLocation(aUci, aOperationTypes, lLocation, True, aReportPath, aRunMade))
        Next lLocation
        Return lReport
    End Function

    Private Function AreaReportLocation(ByVal aUci As HspfUci, ByVal aOperationtypes As atcCollection, _
                                        ByVal aLocation As String, ByVal aLandUseReport As Boolean, _
                                        ByVal aReportPath As String, ByVal aRunMade As String) As String
        If aLandUseReport Then
            Dim lReport As New atcReport.ReportText
            lReport.AppendLine("LanduseArea Summary Report at " & aLocation)
            lReport.AppendLine("   UCI File Name " & aUci.Name)
            lReport.AppendLine("   Run Made " & aRunMade)
            lReport.AppendLine("   " & aUci.GlobalBlock.RunInf.Value)
            lReport.AppendLine("")
            lReport.AppendLine("Landuse".PadLeft(20) & vbTab & _
                           "PervArea".PadLeft(12) & vbTab & _
                           "ImpvArea".PadLeft(12) & vbTab & _
                           "TotalArea".PadLeft(12))
            Dim lLandUses As atcCollection = LandUses(aUci, aOperationtypes, aLocation)
            Dim lLandUsesCombinePervImpv As atcCollection = LandUsesCombined(lLandUses)
            Dim lTotalAreaFromLandUses As Double = 0
            Dim lTotalAreaPerv As Double = 0.0
            Dim lTotalAreaImpr As Double = 0.0
            For lLandUseIndex As Integer = 0 To lLandUsesCombinePervImpv.Count - 1
                Dim lLandUseAreaString As String = lLandUsesCombinePervImpv.Item(lLandUseIndex)
                Dim lImprArea As Double = StrRetRem(lLandUseAreaString)
                Dim lPervArea As Double = 0
                If lLandUseAreaString.Length > 0 Then
                    lPervArea = lLandUseAreaString
                End If


                Dim lLandUseArea As Double = lPervArea + lImprArea
                lReport.AppendLine(lLandUsesCombinePervImpv.Keys(lLandUseIndex).ToString.PadLeft(20) & vbTab & _
                               DecimalAlign(lPervArea, , 2, 7) & vbTab & _
                               DecimalAlign(lImprArea, , 2, 7) & vbTab & _
                               DecimalAlign(lLandUseArea, , 2, 7))
                lTotalAreaPerv += lPervArea
                lTotalAreaImpr += lImprArea
                lTotalAreaFromLandUses += lLandUseArea
            Next
            lLandUsesCombinePervImpv.Clear()
            lLandUses.Clear()
            lReport.AppendLine("")
            lReport.AppendLine("Total".PadLeft(20) & vbTab & _
                           DecimalAlign(lTotalAreaPerv, , 2, 7) & vbTab & _
                           DecimalAlign(lTotalAreaImpr, , 2, 7) & vbTab & _
                           DecimalAlign(lTotalAreaFromLandUses, , 2, 7))
            SaveFileString(aReportPath & SafeFilename("AreaLanduse_" & aLocation & ".txt"), lReport.ToString)
        End If

        Dim lLocations As atcCollection = UpstreamLocations(aUci, aOperationtypes, aLocation)
        Dim lTotalArea As Double = 0.0
        For lIndex As Integer = 0 To lLocations.Count - 1
            If lLocations.Item(lIndex) IsNot Nothing Then
                lTotalArea += lLocations.Item(lIndex)
            End If
        Next

        lLocations.Clear()
        Dim lUpstreamLocations As New atcCollection
        Dim lUpstreamLocationsString As String = ""
        Dim lLocalArea As Double = 0.0
        LocationAreaCalc(aUci, aLocation, aOperationtypes, lLocations, False)
        For lIndex As Integer = 0 To lLocations.Count - 1
            lLocalArea += lLocations.Item(lIndex)
            If lLocations.Item(lIndex) < 0.00001 Then
                Dim lLocation As String = lLocations.Keys(lIndex)
                If lLocation <> aLocation Then
                    lUpstreamLocations.Add(lLocation)
                    lUpstreamLocationsString &= lLocations.Keys(lIndex) & ", "
                End If
            End If
        Next

        If lUpstreamLocationsString.Length > 0 Then
            lUpstreamLocationsString = lUpstreamLocationsString.Remove(lUpstreamLocationsString.Length - 2, 2)
        End If
        Dim lStr As String = ""
        For Each lUpstreamLocation As String In lUpstreamLocations
            lStr &= AreaReportLocation(aUci, aOperationtypes, lUpstreamLocation, aLandUseReport, aReportPath, aRunMade)
        Next
        lUpstreamLocations.Clear()
        lStr &= aLocation.PadRight(8) & vbTab & _
                DecimalAlign(lTotalArea, , 2, 7) & vbTab & _
                DecimalAlign(lLocalArea, , 2, 7) & vbTab & _
                lUpstreamLocationsString & vbCrLf
        Return lStr
    End Function

    Private Function LandUsesCombined(ByVal aLandUses As atcCollection) As atcCollection
        Dim lLUCombined As New atcCollection
        For lIndex As Integer = 0 To aLandUses.Count - 1
            Dim lLandUseName As String = aLandUses.Keys(lIndex).ToString
            Dim lLandUse As atcCollection = aLandUses.Item(lIndex)
            Dim lLandUseArea As Double = 0.0
            For lOperationIndex As Integer = 0 To lLandUse.Count - 1
                lLandUseArea += lLandUse.Item(lOperationIndex)
            Next
            If lLandUseArea > 0 Then
                Dim lLandUseKey As Integer = lLUCombined.IndexFromKey(lLandUseName.Remove(0, 2))
                Dim lLandUseString As String = ""
                If lLandUseKey = -1 Then
                    lLandUseString = lLandUseArea
                    If lLandUseName.StartsWith("P") Then
                        lLandUseString = "0.0," & lLandUseString
                    End If
                    lLUCombined.Add(lLandUseName.Remove(0, 2), lLandUseString)
                Else
                    lLUCombined(lLandUseKey) &= "," & lLandUseArea
                End If
            End If
        Next
        For lIndex As Integer = 0 To lLUCombined.Count - 1
            If Not lLUCombined.ItemByIndex(lIndex).Contains(",") Then
                lLUCombined.ItemByIndex(lIndex) &= ",0.0"
            End If
        Next
        Return lLUCombined
    End Function
End Module
