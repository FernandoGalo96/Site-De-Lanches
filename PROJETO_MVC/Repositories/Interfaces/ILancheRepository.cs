﻿using LANCHESMVC.Models;

namespace LANCHESMVC.Repositories.Interfaces;

public interface ILancheRepository
{
    IEnumerable<Lanche> Lanches { get; }
    IEnumerable<Lanche> LanchesPreferidos { get; }

    Lanche GetLancheById(int lancheid);
}