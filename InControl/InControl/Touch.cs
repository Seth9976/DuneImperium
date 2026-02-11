using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000053 RID: 83
	public class Touch : global::Il2CppSystem.Object
	{
		// Token: 0x0600081C RID: 2076 RVA: 0x000243D0 File Offset: 0x000225D0
		// Note: this type is marked as 'beforefieldinit'.
		static Touch()
		{
			Il2CppClassPointerStore<Touch>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "Touch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Touch>.NativeClassPtr);
			Touch.NativeFieldInfoPtr_FingerID_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "FingerID_None");
			Touch.NativeFieldInfoPtr_FingerID_Mouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "FingerID_Mouse");
			Touch.NativeFieldInfoPtr_fingerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "fingerId");
			Touch.NativeFieldInfoPtr_mouseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "mouseButton");
			Touch.NativeFieldInfoPtr_phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "phase");
			Touch.NativeFieldInfoPtr_tapCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "tapCount");
			Touch.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "position");
			Touch.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "startPosition");
			Touch.NativeFieldInfoPtr_deltaPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "deltaPosition");
			Touch.NativeFieldInfoPtr_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "lastPosition");
			Touch.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "deltaTime");
			Touch.NativeFieldInfoPtr_updateTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "updateTick");
			Touch.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "type");
			Touch.NativeFieldInfoPtr_altitudeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "altitudeAngle");
			Touch.NativeFieldInfoPtr_azimuthAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "azimuthAngle");
			Touch.NativeFieldInfoPtr_maximumPossiblePressure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "maximumPossiblePressure");
			Touch.NativeFieldInfoPtr_pressure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "pressure");
			Touch.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "radius");
			Touch.NativeFieldInfoPtr_radiusVariance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "radiusVariance");
			Touch.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100664337);
			Touch.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100664338);
			Touch.NativeMethodInfoPtr_get_normalizedPressure_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100664339);
			Touch.NativeMethodInfoPtr_get_NormalizedPressure_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100664340);
			Touch.NativeMethodInfoPtr_get_IsMouse_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100664341);
			Touch.NativeMethodInfoPtr_SetWithTouchData_Internal_Void_Touch_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100664342);
			Touch.NativeMethodInfoPtr_SetWithMouseData_Internal_Boolean_Int32_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100664343);
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00024608 File Offset: 0x00022808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784990, XrefRangeEnd = 784991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Touch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Touch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00024644 File Offset: 0x00022844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784991, XrefRangeEnd = 784999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x00024678 File Offset: 0x00022878
		public unsafe float normalizedPressure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_normalizedPressure_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x000246B4 File Offset: 0x000228B4
		public unsafe float NormalizedPressure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_NormalizedPressure_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x000246F0 File Offset: 0x000228F0
		public unsafe bool IsMouse
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 784999, RefRangeEnd = 785000, XrefRangeStart = 784999, XrefRangeEnd = 784999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_IsMouse_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0002472C File Offset: 0x0002292C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 785016, RefRangeEnd = 785017, XrefRangeStart = 785000, XrefRangeEnd = 785016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWithTouchData(Touch touch, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_SetWithTouchData_Internal_Void_Touch_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00024788 File Offset: 0x00022988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 785042, RefRangeEnd = 785043, XrefRangeStart = 785017, XrefRangeEnd = 785042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetWithMouseData(int button, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_SetWithMouseData_Internal_Boolean_Int32_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x000053D0 File Offset: 0x000035D0
		public Touch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x000247F0 File Offset: 0x000229F0
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x000053D9 File Offset: 0x000035D9
		public unsafe static int FingerID_None
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Touch.NativeFieldInfoPtr_FingerID_None, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Touch.NativeFieldInfoPtr_FingerID_None, (void*)(&value));
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x0002480C File Offset: 0x00022A0C
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x000053E7 File Offset: 0x000035E7
		public unsafe static int FingerID_Mouse
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Touch.NativeFieldInfoPtr_FingerID_Mouse, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Touch.NativeFieldInfoPtr_FingerID_Mouse, (void*)(&value));
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x00024828 File Offset: 0x00022A28
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x000053F5 File Offset: 0x000035F5
		public unsafe int fingerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_fingerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_fingerId)) = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x00024850 File Offset: 0x00022A50
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x00005410 File Offset: 0x00003610
		public unsafe int mouseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_mouseButton);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_mouseButton)) = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x00024878 File Offset: 0x00022A78
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x0000542B File Offset: 0x0000362B
		public unsafe TouchPhase phase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_phase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_phase)) = value;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x000248A0 File Offset: 0x00022AA0
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x00005446 File Offset: 0x00003646
		public unsafe int tapCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_tapCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_tapCount)) = value;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x000248C8 File Offset: 0x00022AC8
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x00005461 File Offset: 0x00003661
		public unsafe Vector2 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x000248F0 File Offset: 0x00022AF0
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x0000547C File Offset: 0x0000367C
		public unsafe Vector2 startPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_startPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_startPosition)) = value;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x00024918 File Offset: 0x00022B18
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x00005497 File Offset: 0x00003697
		public unsafe Vector2 deltaPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_deltaPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_deltaPosition)) = value;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x00024940 File Offset: 0x00022B40
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x000054B2 File Offset: 0x000036B2
		public unsafe Vector2 lastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_lastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_lastPosition)) = value;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x00024968 File Offset: 0x00022B68
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x000054CD File Offset: 0x000036CD
		public unsafe float deltaTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_deltaTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_deltaTime)) = value;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x00024990 File Offset: 0x00022B90
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x000054E8 File Offset: 0x000036E8
		public unsafe ulong updateTick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_updateTick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_updateTick)) = value;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x000249B8 File Offset: 0x00022BB8
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x00005503 File Offset: 0x00003703
		public unsafe TouchType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x000249E0 File Offset: 0x00022BE0
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x0000551E File Offset: 0x0000371E
		public unsafe float altitudeAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_altitudeAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_altitudeAngle)) = value;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x00024A08 File Offset: 0x00022C08
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x00005539 File Offset: 0x00003739
		public unsafe float azimuthAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_azimuthAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_azimuthAngle)) = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00024A30 File Offset: 0x00022C30
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x00005554 File Offset: 0x00003754
		public unsafe float maximumPossiblePressure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_maximumPossiblePressure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_maximumPossiblePressure)) = value;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x00024A58 File Offset: 0x00022C58
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x0000556F File Offset: 0x0000376F
		public unsafe float pressure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_pressure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_pressure)) = value;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x00024A80 File Offset: 0x00022C80
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x0000558A File Offset: 0x0000378A
		public unsafe float radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_radius)) = value;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x00024AA8 File Offset: 0x00022CA8
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x000055A5 File Offset: 0x000037A5
		public unsafe float radiusVariance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_radiusVariance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Touch.NativeFieldInfoPtr_radiusVariance)) = value;
			}
		}

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeFieldInfoPtr_FingerID_None;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeFieldInfoPtr_FingerID_Mouse;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeFieldInfoPtr_fingerId;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeFieldInfoPtr_mouseButton;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeFieldInfoPtr_phase;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeFieldInfoPtr_tapCount;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeFieldInfoPtr_startPosition;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeFieldInfoPtr_deltaPosition;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeFieldInfoPtr_lastPosition;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeFieldInfoPtr_deltaTime;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeFieldInfoPtr_updateTick;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeFieldInfoPtr_altitudeAngle;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeFieldInfoPtr_azimuthAngle;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeFieldInfoPtr_maximumPossiblePressure;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeFieldInfoPtr_pressure;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeFieldInfoPtr_radius;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeFieldInfoPtr_radiusVariance;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_get_normalizedPressure_Public_get_Single_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedPressure_Public_get_Single_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMouse_Public_get_Boolean_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_SetWithTouchData_Internal_Void_Touch_UInt64_Single_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_SetWithMouseData_Internal_Boolean_Int32_UInt64_Single_0;
	}
}
