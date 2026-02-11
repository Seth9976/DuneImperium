using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[StructLayout(2)]
	public struct Touch
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002544 File Offset: 0x00000744
		// Note: this type is marked as 'beforefieldinit'.
		static Touch()
		{
			Il2CppClassPointerStore<Touch>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputLegacyModule.dll", "UnityEngine", "Touch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Touch>.NativeClassPtr);
			Touch.NativeFieldInfoPtr_m_FingerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_FingerId");
			Touch.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_Position");
			Touch.NativeFieldInfoPtr_m_RawPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_RawPosition");
			Touch.NativeFieldInfoPtr_m_PositionDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_PositionDelta");
			Touch.NativeFieldInfoPtr_m_TimeDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_TimeDelta");
			Touch.NativeFieldInfoPtr_m_TapCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_TapCount");
			Touch.NativeFieldInfoPtr_m_Phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_Phase");
			Touch.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_Type");
			Touch.NativeFieldInfoPtr_m_Pressure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_Pressure");
			Touch.NativeFieldInfoPtr_m_maximumPossiblePressure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_maximumPossiblePressure");
			Touch.NativeFieldInfoPtr_m_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_Radius");
			Touch.NativeFieldInfoPtr_m_RadiusVariance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_RadiusVariance");
			Touch.NativeFieldInfoPtr_m_AltitudeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_AltitudeAngle");
			Touch.NativeFieldInfoPtr_m_AzimuthAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_AzimuthAngle");
			Touch.NativeMethodInfoPtr_get_fingerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663297);
			Touch.NativeMethodInfoPtr_get_position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663298);
			Touch.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663299);
			Touch.NativeMethodInfoPtr_get_rawPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663300);
			Touch.NativeMethodInfoPtr_set_rawPosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663301);
			Touch.NativeMethodInfoPtr_get_deltaPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663302);
			Touch.NativeMethodInfoPtr_set_deltaPosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663303);
			Touch.NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663304);
			Touch.NativeMethodInfoPtr_get_tapCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663305);
			Touch.NativeMethodInfoPtr_get_phase_Public_get_TouchPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663306);
			Touch.NativeMethodInfoPtr_get_pressure_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663307);
			Touch.NativeMethodInfoPtr_get_maximumPossiblePressure_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663308);
			Touch.NativeMethodInfoPtr_get_type_Public_get_TouchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663309);
			Touch.NativeMethodInfoPtr_get_altitudeAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663310);
			Touch.NativeMethodInfoPtr_get_azimuthAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663311);
			Touch.NativeMethodInfoPtr_get_radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663312);
			Touch.NativeMethodInfoPtr_get_radiusVariance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663313);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x000027E0 File Offset: 0x000009E0
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002062 File Offset: 0x00000262
		public unsafe int fingerId
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_fingerId_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_FingerId = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002810 File Offset: 0x00000A10
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002840 File Offset: 0x00000A40
		public unsafe Vector2 position
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 1253339, RefRangeEnd = 1253368, XrefRangeStart = 1253339, XrefRangeEnd = 1253368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_position_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1266722, RefRangeEnd = 1266724, XrefRangeStart = 1266722, XrefRangeEnd = 1266722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002874 File Offset: 0x00000A74
		// (set) Token: 0x06000006 RID: 6 RVA: 0x000028A4 File Offset: 0x00000AA4
		public unsafe Vector2 rawPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1266724, RefRangeEnd = 1266725, XrefRangeStart = 1266724, XrefRangeEnd = 1266724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_rawPosition_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1266725, RefRangeEnd = 1266726, XrefRangeStart = 1266725, XrefRangeEnd = 1266725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_set_rawPosition_Public_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000028D8 File Offset: 0x00000AD8
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002908 File Offset: 0x00000B08
		public unsafe Vector2 deltaPosition
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1266726, RefRangeEnd = 1266731, XrefRangeStart = 1266726, XrefRangeEnd = 1266726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_deltaPosition_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1118921, RefRangeEnd = 1118923, XrefRangeStart = 1118921, XrefRangeEnd = 1118923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_set_deltaPosition_Public_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000293C File Offset: 0x00000B3C
		// (set) Token: 0x06000015 RID: 21 RVA: 0x0000206C File Offset: 0x0000026C
		public unsafe float deltaTime
		{
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 1252657, RefRangeEnd = 1252710, XrefRangeStart = 1252657, XrefRangeEnd = 1252710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_TimeDelta = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000296C File Offset: 0x00000B6C
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002076 File Offset: 0x00000276
		public unsafe int tapCount
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 337415, RefRangeEnd = 337422, XrefRangeStart = 337415, XrefRangeEnd = 337422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_tapCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_TapCount = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0000299C File Offset: 0x00000B9C
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002080 File Offset: 0x00000280
		public unsafe TouchPhase phase
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 1266731, RefRangeEnd = 1266757, XrefRangeStart = 1266731, XrefRangeEnd = 1266731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_phase_Public_get_TouchPhase_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Phase = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000029CC File Offset: 0x00000BCC
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000208A File Offset: 0x0000028A
		public unsafe float pressure
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 318216, RefRangeEnd = 318232, XrefRangeStart = 318216, XrefRangeEnd = 318232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_pressure_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Pressure = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000029FC File Offset: 0x00000BFC
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002094 File Offset: 0x00000294
		public unsafe float maximumPossiblePressure
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1252736, RefRangeEnd = 1252741, XrefRangeStart = 1252736, XrefRangeEnd = 1252741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_maximumPossiblePressure_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_maximumPossiblePressure = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002A2C File Offset: 0x00000C2C
		// (set) Token: 0x0600001A RID: 26 RVA: 0x0000209E File Offset: 0x0000029E
		public unsafe TouchType type
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 678450, RefRangeEnd = 678472, XrefRangeStart = 678450, XrefRangeEnd = 678472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_type_Public_get_TouchType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Type = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002A5C File Offset: 0x00000C5C
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000020A8 File Offset: 0x000002A8
		public unsafe float altitudeAngle
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1032748, RefRangeEnd = 1032751, XrefRangeStart = 1032748, XrefRangeEnd = 1032751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_altitudeAngle_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_AltitudeAngle = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002A8C File Offset: 0x00000C8C
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000020B2 File Offset: 0x000002B2
		public unsafe float azimuthAngle
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1088553, RefRangeEnd = 1088556, XrefRangeStart = 1088553, XrefRangeEnd = 1088556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_azimuthAngle_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_AzimuthAngle = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002ABC File Offset: 0x00000CBC
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000020BC File Offset: 0x000002BC
		public unsafe float radius
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 1252741, RefRangeEnd = 1252755, XrefRangeStart = 1252741, XrefRangeEnd = 1252755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_radius_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Radius = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002AEC File Offset: 0x00000CEC
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000020C6 File Offset: 0x000002C6
		public unsafe float radiusVariance
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 1032702, RefRangeEnd = 1032747, XrefRangeStart = 1032702, XrefRangeEnd = 1032747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_radiusVariance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_RadiusVariance = value;
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Touch>.NativeClassPtr, ref this));
		}

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_m_FingerId;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_m_Position;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_m_RawPosition;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_m_PositionDelta;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeDelta;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_m_TapCount;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_m_Pressure;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_m_maximumPossiblePressure;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_m_Radius;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_m_RadiusVariance;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_m_AltitudeAngle;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_m_AzimuthAngle;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_get_fingerId_Public_get_Int32_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector2_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_get_rawPosition_Public_get_Vector2_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_set_rawPosition_Public_set_Void_Vector2_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaPosition_Public_get_Vector2_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_set_deltaPosition_Public_set_Void_Vector2_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_get_tapCount_Public_get_Int32_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_get_phase_Public_get_TouchPhase_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_get_pressure_Public_get_Single_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_get_maximumPossiblePressure_Public_get_Single_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_TouchType_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_get_altitudeAngle_Public_get_Single_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_get_azimuthAngle_Public_get_Single_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_get_radius_Public_get_Single_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_get_radiusVariance_Public_get_Single_0;

		// Token: 0x0400002E RID: 46
		[FieldOffset(0)]
		public int m_FingerId;

		// Token: 0x0400002F RID: 47
		[FieldOffset(4)]
		public Vector2 m_Position;

		// Token: 0x04000030 RID: 48
		[FieldOffset(12)]
		public Vector2 m_RawPosition;

		// Token: 0x04000031 RID: 49
		[FieldOffset(20)]
		public Vector2 m_PositionDelta;

		// Token: 0x04000032 RID: 50
		[FieldOffset(28)]
		public float m_TimeDelta;

		// Token: 0x04000033 RID: 51
		[FieldOffset(32)]
		public int m_TapCount;

		// Token: 0x04000034 RID: 52
		[FieldOffset(36)]
		public TouchPhase m_Phase;

		// Token: 0x04000035 RID: 53
		[FieldOffset(40)]
		public TouchType m_Type;

		// Token: 0x04000036 RID: 54
		[FieldOffset(44)]
		public float m_Pressure;

		// Token: 0x04000037 RID: 55
		[FieldOffset(48)]
		public float m_maximumPossiblePressure;

		// Token: 0x04000038 RID: 56
		[FieldOffset(52)]
		public float m_Radius;

		// Token: 0x04000039 RID: 57
		[FieldOffset(56)]
		public float m_RadiusVariance;

		// Token: 0x0400003A RID: 58
		[FieldOffset(60)]
		public float m_AltitudeAngle;

		// Token: 0x0400003B RID: 59
		[FieldOffset(64)]
		public float m_AzimuthAngle;
	}
}
