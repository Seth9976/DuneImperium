using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.debug
{
	// Token: 0x0200000D RID: 13
	public class Timelord : MonoBehaviour
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x000047D4 File Offset: 0x000029D4
		// Note: this type is marked as 'beforefieldinit'.
		static Timelord()
		{
			Il2CppClassPointerStore<Timelord>.NativeClassPtr = IL2CPP.GetIl2CppClass("console.dll", "dwd.core.debug", "Timelord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Timelord>.NativeClassPtr);
			Timelord.NativeFieldInfoPtr_spedUpTimeHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timelord>.NativeClassPtr, "spedUpTimeHotkeys");
			Timelord.NativeFieldInfoPtr_slowedDownTimeHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timelord>.NativeClassPtr, "slowedDownTimeHotkeys");
			Timelord.NativeFieldInfoPtr_spedUpTimescale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timelord>.NativeClassPtr, "spedUpTimescale");
			Timelord.NativeFieldInfoPtr_slowedDownTimescale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timelord>.NativeClassPtr, "slowedDownTimescale");
			Timelord.NativeFieldInfoPtr_defaultTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timelord>.NativeClassPtr, "defaultTimeScale");
			Timelord.NativeFieldInfoPtr_speedUpActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timelord>.NativeClassPtr, "speedUpActive");
			Timelord.NativeFieldInfoPtr_slowDownActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timelord>.NativeClassPtr, "slowDownActive");
			Timelord.NativeMethodInfoPtr_get_DefaultTimeScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timelord>.NativeClassPtr, 100663349);
			Timelord.NativeMethodInfoPtr_set_DefaultTimeScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timelord>.NativeClassPtr, 100663350);
			Timelord.NativeMethodInfoPtr_get_SpeedUpActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timelord>.NativeClassPtr, 100663351);
			Timelord.NativeMethodInfoPtr_set_SpeedUpActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timelord>.NativeClassPtr, 100663352);
			Timelord.NativeMethodInfoPtr_get_SlowDownActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timelord>.NativeClassPtr, 100663353);
			Timelord.NativeMethodInfoPtr_set_SlowDownActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timelord>.NativeClassPtr, 100663354);
			Timelord.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timelord>.NativeClassPtr, 100663355);
			Timelord.NativeMethodInfoPtr_updateTimeScale_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timelord>.NativeClassPtr, 100663356);
			Timelord.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timelord>.NativeClassPtr, 100663357);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00004944 File Offset: 0x00002B44
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00004980 File Offset: 0x00002B80
		public unsafe float DefaultTimeScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timelord.NativeMethodInfoPtr_get_DefaultTimeScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255944, XrefRangeEnd = 1255945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timelord.NativeMethodInfoPtr_set_DefaultTimeScale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x000049C0 File Offset: 0x00002BC0
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x000049FC File Offset: 0x00002BFC
		public unsafe bool SpeedUpActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timelord.NativeMethodInfoPtr_get_SpeedUpActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timelord.NativeMethodInfoPtr_set_SpeedUpActive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00004A3C File Offset: 0x00002C3C
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00004A78 File Offset: 0x00002C78
		public unsafe bool SlowDownActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timelord.NativeMethodInfoPtr_get_SlowDownActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timelord.NativeMethodInfoPtr_set_SlowDownActive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 359432, RefRangeEnd = 359440, XrefRangeStart = 359432, XrefRangeEnd = 359440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timelord.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00004AEC File Offset: 0x00002CEC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateTimeScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timelord.NativeMethodInfoPtr_updateTimeScale_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00004B20 File Offset: 0x00002D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255945, XrefRangeEnd = 1255955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Timelord()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Timelord>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timelord.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002679 File Offset: 0x00000879
		public Timelord(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00004B5C File Offset: 0x00002D5C
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00002682 File Offset: 0x00000882
		public unsafe Il2CppStructArray<KeyCode> spedUpTimeHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timelord.NativeFieldInfoPtr_spedUpTimeHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<KeyCode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timelord.NativeFieldInfoPtr_spedUpTimeHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00004B8C File Offset: 0x00002D8C
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x000026A1 File Offset: 0x000008A1
		public unsafe Il2CppStructArray<KeyCode> slowedDownTimeHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timelord.NativeFieldInfoPtr_slowedDownTimeHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<KeyCode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timelord.NativeFieldInfoPtr_slowedDownTimeHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00004BBC File Offset: 0x00002DBC
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x000026C0 File Offset: 0x000008C0
		public unsafe float spedUpTimescale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timelord.NativeFieldInfoPtr_spedUpTimescale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timelord.NativeFieldInfoPtr_spedUpTimescale)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00004BE4 File Offset: 0x00002DE4
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x000026DB File Offset: 0x000008DB
		public unsafe float slowedDownTimescale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timelord.NativeFieldInfoPtr_slowedDownTimescale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timelord.NativeFieldInfoPtr_slowedDownTimescale)) = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00004C0C File Offset: 0x00002E0C
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x000026F6 File Offset: 0x000008F6
		public unsafe float defaultTimeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timelord.NativeFieldInfoPtr_defaultTimeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timelord.NativeFieldInfoPtr_defaultTimeScale)) = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00004C34 File Offset: 0x00002E34
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002711 File Offset: 0x00000911
		public unsafe bool speedUpActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timelord.NativeFieldInfoPtr_speedUpActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timelord.NativeFieldInfoPtr_speedUpActive)) = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00004C5C File Offset: 0x00002E5C
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0000272C File Offset: 0x0000092C
		public unsafe bool slowDownActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timelord.NativeFieldInfoPtr_slowDownActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timelord.NativeFieldInfoPtr_slowDownActive)) = value;
			}
		}

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_spedUpTimeHotkeys;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_slowedDownTimeHotkeys;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_spedUpTimescale;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_slowedDownTimescale;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_defaultTimeScale;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_speedUpActive;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_slowDownActive;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultTimeScale_Public_get_Single_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultTimeScale_Public_set_Void_Single_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_get_SpeedUpActive_Public_get_Boolean_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_set_SpeedUpActive_Public_set_Void_Boolean_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_get_SlowDownActive_Public_get_Boolean_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_set_SlowDownActive_Public_set_Void_Boolean_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_updateTimeScale_Private_Void_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
