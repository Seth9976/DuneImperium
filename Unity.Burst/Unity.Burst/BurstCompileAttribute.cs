using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Burst
{
	// Token: 0x02000008 RID: 8
	public class BurstCompileAttribute : Attribute
	{
		// Token: 0x0600000B RID: 11 RVA: 0x000035F8 File Offset: 0x000017F8
		// Note: this type is marked as 'beforefieldinit'.
		static BurstCompileAttribute()
		{
			Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "BurstCompileAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr);
			BurstCompileAttribute.NativeFieldInfoPtr__FloatMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, "<FloatMode>k__BackingField");
			BurstCompileAttribute.NativeFieldInfoPtr__FloatPrecision_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, "<FloatPrecision>k__BackingField");
			BurstCompileAttribute.NativeFieldInfoPtr__compileSynchronously = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, "_compileSynchronously");
			BurstCompileAttribute.NativeFieldInfoPtr__debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, "_debug");
			BurstCompileAttribute.NativeFieldInfoPtr__disableSafetyChecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, "_disableSafetyChecks");
			BurstCompileAttribute.NativeFieldInfoPtr__disableDirectCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, "_disableDirectCall");
			BurstCompileAttribute.NativeFieldInfoPtr__OptimizeFor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, "<OptimizeFor>k__BackingField");
			BurstCompileAttribute.NativeFieldInfoPtr__Options_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, "<Options>k__BackingField");
			BurstCompileAttribute.NativeMethodInfoPtr_get_FloatMode_Public_get_FloatMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663301);
			BurstCompileAttribute.NativeMethodInfoPtr_set_FloatMode_Public_set_Void_FloatMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663302);
			BurstCompileAttribute.NativeMethodInfoPtr_get_FloatPrecision_Public_get_FloatPrecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663303);
			BurstCompileAttribute.NativeMethodInfoPtr_set_FloatPrecision_Public_set_Void_FloatPrecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663304);
			BurstCompileAttribute.NativeMethodInfoPtr_get_CompileSynchronously_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663305);
			BurstCompileAttribute.NativeMethodInfoPtr_set_CompileSynchronously_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663306);
			BurstCompileAttribute.NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663307);
			BurstCompileAttribute.NativeMethodInfoPtr_set_Debug_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663308);
			BurstCompileAttribute.NativeMethodInfoPtr_get_DisableSafetyChecks_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663309);
			BurstCompileAttribute.NativeMethodInfoPtr_set_DisableSafetyChecks_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663310);
			BurstCompileAttribute.NativeMethodInfoPtr_get_DisableDirectCall_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663311);
			BurstCompileAttribute.NativeMethodInfoPtr_set_DisableDirectCall_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663312);
			BurstCompileAttribute.NativeMethodInfoPtr_get_OptimizeFor_Public_get_OptimizeFor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663313);
			BurstCompileAttribute.NativeMethodInfoPtr_set_OptimizeFor_Public_set_Void_OptimizeFor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663314);
			BurstCompileAttribute.NativeMethodInfoPtr_get_Options_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663315);
			BurstCompileAttribute.NativeMethodInfoPtr_set_Options_Internal_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663316);
			BurstCompileAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663317);
			BurstCompileAttribute.NativeMethodInfoPtr__ctor_Public_Void_FloatPrecision_FloatMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663318);
			BurstCompileAttribute.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr, 100663319);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00003844 File Offset: 0x00001A44
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00003880 File Offset: 0x00001A80
		public unsafe FloatMode FloatMode
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_get_FloatMode_Public_get_FloatMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_set_FloatMode_Public_set_Void_FloatMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000038C0 File Offset: 0x00001AC0
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000038FC File Offset: 0x00001AFC
		public unsafe FloatPrecision FloatPrecision
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_get_FloatPrecision_Public_get_FloatPrecision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_set_FloatPrecision_Public_set_Void_FloatPrecision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000393C File Offset: 0x00001B3C
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00003978 File Offset: 0x00001B78
		public unsafe bool CompileSynchronously
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050661, XrefRangeEnd = 1050665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_get_CompileSynchronously_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1050668, RefRangeEnd = 1050669, XrefRangeStart = 1050665, XrefRangeEnd = 1050668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_set_CompileSynchronously_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000039B8 File Offset: 0x00001BB8
		// (set) Token: 0x06000013 RID: 19 RVA: 0x000039F4 File Offset: 0x00001BF4
		public unsafe bool Debug
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050669, XrefRangeEnd = 1050673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050673, XrefRangeEnd = 1050676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_set_Debug_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00003A34 File Offset: 0x00001C34
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00003A70 File Offset: 0x00001C70
		public unsafe bool DisableSafetyChecks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050676, XrefRangeEnd = 1050680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_get_DisableSafetyChecks_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050680, XrefRangeEnd = 1050683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_set_DisableSafetyChecks_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00003AB0 File Offset: 0x00001CB0
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00003AEC File Offset: 0x00001CEC
		public unsafe bool DisableDirectCall
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050683, XrefRangeEnd = 1050687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_get_DisableDirectCall_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050687, XrefRangeEnd = 1050690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_set_DisableDirectCall_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00003B2C File Offset: 0x00001D2C
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00003B68 File Offset: 0x00001D68
		public unsafe OptimizeFor OptimizeFor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_get_OptimizeFor_Public_get_OptimizeFor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_set_OptimizeFor_Public_set_Void_OptimizeFor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00003BA8 File Offset: 0x00001DA8
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00003BE8 File Offset: 0x00001DE8
		public unsafe Il2CppStringArray Options
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_get_Options_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr_set_Options_Internal_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003C2C File Offset: 0x00001E2C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BurstCompileAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003C68 File Offset: 0x00001E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050690, XrefRangeEnd = 1050691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BurstCompileAttribute(FloatPrecision floatPrecision, FloatMode floatMode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref floatPrecision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floatMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr__ctor_Public_Void_FloatPrecision_FloatMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 464354, RefRangeEnd = 464355, XrefRangeStart = 464354, XrefRangeEnd = 464355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BurstCompileAttribute(Il2CppStringArray options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompileAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompileAttribute.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020DD File Offset: 0x000002DD
		public BurstCompileAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00003D0C File Offset: 0x00001F0C
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000020E6 File Offset: 0x000002E6
		public unsafe FloatMode _FloatMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__FloatMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__FloatMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00003D34 File Offset: 0x00001F34
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002101 File Offset: 0x00000301
		public unsafe FloatPrecision _FloatPrecision_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__FloatPrecision_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__FloatPrecision_k__BackingField)) = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00003D5C File Offset: 0x00001F5C
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0000211C File Offset: 0x0000031C
		public Nullable<bool> _compileSynchronously
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__compileSynchronously);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__compileSynchronously), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00003D8C File Offset: 0x00001F8C
		// (set) Token: 0x06000027 RID: 39 RVA: 0x0000214A File Offset: 0x0000034A
		public Nullable<bool> _debug
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__debug);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__debug), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00003DBC File Offset: 0x00001FBC
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002178 File Offset: 0x00000378
		public Nullable<bool> _disableSafetyChecks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__disableSafetyChecks);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__disableSafetyChecks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003DEC File Offset: 0x00001FEC
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000021A6 File Offset: 0x000003A6
		public Nullable<bool> _disableDirectCall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__disableDirectCall);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__disableDirectCall), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00003E1C File Offset: 0x0000201C
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000021D4 File Offset: 0x000003D4
		public unsafe OptimizeFor _OptimizeFor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__OptimizeFor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__OptimizeFor_k__BackingField)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00003E44 File Offset: 0x00002044
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000021EF File Offset: 0x000003EF
		public unsafe Il2CppStringArray _Options_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__Options_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompileAttribute.NativeFieldInfoPtr__Options_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr__FloatMode_k__BackingField;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr__FloatPrecision_k__BackingField;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr__compileSynchronously;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr__debug;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr__disableSafetyChecks;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr__disableDirectCall;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr__OptimizeFor_k__BackingField;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr__Options_k__BackingField;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_get_FloatMode_Public_get_FloatMode_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_set_FloatMode_Public_set_Void_FloatMode_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_get_FloatPrecision_Public_get_FloatPrecision_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_set_FloatPrecision_Public_set_Void_FloatPrecision_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_CompileSynchronously_Public_get_Boolean_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_set_CompileSynchronously_Public_set_Void_Boolean_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_set_Debug_Public_set_Void_Boolean_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_get_DisableSafetyChecks_Public_get_Boolean_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_set_DisableSafetyChecks_Public_set_Void_Boolean_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_get_DisableDirectCall_Public_get_Boolean_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_set_DisableDirectCall_Public_set_Void_Boolean_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_get_OptimizeFor_Public_get_OptimizeFor_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_set_OptimizeFor_Public_set_Void_OptimizeFor_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Internal_get_Il2CppStringArray_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_set_Options_Internal_set_Void_Il2CppStringArray_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FloatPrecision_FloatMode_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStringArray_0;
	}
}
