// SPDX-FileCopyrightText: 2026 Chapien <inquiries@chapien.net>
//
// SPDX-License-Identifier: MPL-2.0+

namespace Content.Shared.Moonflower;

public sealed class TimeSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();
    }

    public DateTime GetGalaxyDateTime()
    {
        var curr_time = DateTime.UtcNow.AddYears(400);
        return curr_time;
    }

}
