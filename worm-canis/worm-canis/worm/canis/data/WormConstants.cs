using System;
using Canis.attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;

namespace worm.canis.data
{
	// Token: 0x02000041 RID: 65
	public static class WormConstants : Object
	{
		// Token: 0x0600075F RID: 1887 RVA: 0x00082F10 File Offset: 0x00081110
		// Note: this type is marked as 'beforefieldinit'.
		static WormConstants()
		{
			Il2CppClassPointerStore<WormConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data", "WormConstants");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConstants>.NativeClassPtr);
			WormConstants.NativeFieldInfoPtr_AceRecoveryCounters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConstants>.NativeClassPtr, "AceRecoveryCounters");
			WormConstants.NativeFieldInfoPtr_TurnTimerAmounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConstants>.NativeClassPtr, "TurnTimerAmounts");
			WormConstants.NativeFieldInfoPtr_DefaultColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConstants>.NativeClassPtr, "DefaultColors");
			WormConstants.NativeFieldInfoPtr_NormalAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConstants>.NativeClassPtr, "NormalAnimationSpeed");
			WormConstants.NativeFieldInfoPtr_FastAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConstants>.NativeClassPtr, "FastAnimationSpeed");
			WormConstants.NativeFieldInfoPtr_DisabledAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConstants>.NativeClassPtr, "DisabledAnimationSpeed");
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x000051F2 File Offset: 0x000033F2
		public WormConstants(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00082FB8 File Offset: 0x000811B8
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x000051FB File Offset: 0x000033FB
		public unsafe static List<AttributeDefinition<Nullable<int>>> AceRecoveryCounters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormConstants.NativeFieldInfoPtr_AceRecoveryCounters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AttributeDefinition<Nullable<int>>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormConstants.NativeFieldInfoPtr_AceRecoveryCounters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x00082FE0 File Offset: 0x000811E0
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x0000520D File Offset: 0x0000340D
		public unsafe static List<TimeSpan> TurnTimerAmounts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormConstants.NativeFieldInfoPtr_TurnTimerAmounts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TimeSpan>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormConstants.NativeFieldInfoPtr_TurnTimerAmounts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x00083008 File Offset: 0x00081208
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x0000521F File Offset: 0x0000341F
		public unsafe static IReadOnlyList<PieceColor> DefaultColors
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormConstants.NativeFieldInfoPtr_DefaultColors, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<PieceColor>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormConstants.NativeFieldInfoPtr_DefaultColors, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00083030 File Offset: 0x00081230
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00005231 File Offset: 0x00003431
		public unsafe static int NormalAnimationSpeed
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormConstants.NativeFieldInfoPtr_NormalAnimationSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormConstants.NativeFieldInfoPtr_NormalAnimationSpeed, (void*)(&value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x0008304C File Offset: 0x0008124C
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x0000523F File Offset: 0x0000343F
		public unsafe static int FastAnimationSpeed
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormConstants.NativeFieldInfoPtr_FastAnimationSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormConstants.NativeFieldInfoPtr_FastAnimationSpeed, (void*)(&value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x00083068 File Offset: 0x00081268
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x0000524D File Offset: 0x0000344D
		public unsafe static int DisabledAnimationSpeed
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormConstants.NativeFieldInfoPtr_DisabledAnimationSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormConstants.NativeFieldInfoPtr_DisabledAnimationSpeed, (void*)(&value));
			}
		}

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeFieldInfoPtr_AceRecoveryCounters;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeFieldInfoPtr_TurnTimerAmounts;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeFieldInfoPtr_DefaultColors;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeFieldInfoPtr_NormalAnimationSpeed;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeFieldInfoPtr_FastAnimationSpeed;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeFieldInfoPtr_DisabledAnimationSpeed;
	}
}
