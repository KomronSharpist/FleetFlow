﻿using FleetFlow.Domain.Enums;

namespace FleetFlow.Service.DTOs.Bonuses;

public class BonusSettingCreationDto
{
    public BonusType Type { get; set; }
    public string PromoCode { get; set; }
    public decimal? AmountFrom { get; set; }
    public decimal? AmountTo { get; set; }
    public decimal? Amount { get; set; }
    public long? ProductId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}
