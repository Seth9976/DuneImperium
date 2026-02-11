using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200009C RID: 156
	[StructLayout(2)]
	public struct Resolution
	{
		// Token: 0x060009C4 RID: 2500 RVA: 0x00035898 File Offset: 0x00033A98
		// Note: this type is marked as 'beforefieldinit'.
		static Resolution()
		{
			Il2CppClassPointerStore<Resolution>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Resolution");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Resolution>.NativeClassPtr);
			Resolution.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resolution>.NativeClassPtr, "m_Width");
			Resolution.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resolution>.NativeClassPtr, "m_Height");
			Resolution.NativeFieldInfoPtr_m_RefreshRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resolution>.NativeClassPtr, "m_RefreshRate");
			Resolution.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resolution>.NativeClassPtr, 100664400);
			Resolution.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resolution>.NativeClassPtr, 100664401);
			Resolution.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resolution>.NativeClassPtr, 100664402);
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00035940 File Offset: 0x00033B40
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x00005B2E File Offset: 0x00003D2E
		public unsafe int width
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resolution.NativeMethodInfoPtr_get_width_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Width = value;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x00035970 File Offset: 0x00033B70
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x00005B38 File Offset: 0x00003D38
		public unsafe int height
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 283125, RefRangeEnd = 283150, XrefRangeStart = 283125, XrefRangeEnd = 283150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resolution.NativeMethodInfoPtr_get_height_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Height = value;
			}
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x000359A0 File Offset: 0x00033BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650142, XrefRangeEnd = 650162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resolution.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00005B1C File Offset: 0x00003D1C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Resolution>.NativeClassPtr, ref this));
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x000359CC File Offset: 0x00033BCC
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x00005B42 File Offset: 0x00003D42
		public RefreshRate refreshRateRatio
		{
			get
			{
				return this.m_RefreshRate;
			}
			set
			{
				this.m_RefreshRate = value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x000359E4 File Offset: 0x00033BE4
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x00005B4C File Offset: 0x00003D4C
		public int refreshRate
		{
			get
			{
				return (int)Math.Round(this.m_RefreshRate.value);
			}
			set
			{
				this.m_RefreshRate.numerator = (uint)value;
				this.m_RefreshRate.denominator = 1U;
			}
		}

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshRate;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000793 RID: 1939
		[FieldOffset(0)]
		public int m_Width;

		// Token: 0x04000794 RID: 1940
		[FieldOffset(4)]
		public int m_Height;

		// Token: 0x04000795 RID: 1941
		[FieldOffset(8)]
		public RefreshRate m_RefreshRate;
	}
}
