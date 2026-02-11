using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.PropertyVariants.TrackedObjects
{
	// Token: 0x020000FE RID: 254
	[Serializable]
	public class TrackedTransform : TrackedObject
	{
		// Token: 0x06000C48 RID: 3144 RVA: 0x00037904 File Offset: 0x00035B04
		// Note: this type is marked as 'beforefieldinit'.
		static TrackedTransform()
		{
			Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedObjects", "TrackedTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr);
			TrackedTransform.NativeFieldInfoPtr_m_PositionToApply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr, "m_PositionToApply");
			TrackedTransform.NativeFieldInfoPtr_m_RotationToApply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr, "m_RotationToApply");
			TrackedTransform.NativeFieldInfoPtr_m_ScaleToApply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr, "m_ScaleToApply");
			TrackedTransform.NativeFieldInfoPtr_m_PropertyHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr, "m_PropertyHandlers");
			TrackedTransform.NativeMethodInfoPtr_AddPropertyHandlers_Protected_Virtual_New_Void_Dictionary_2_String_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr, 100665330);
			TrackedTransform.NativeMethodInfoPtr_CanTrackProperty_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr, 100665331);
			TrackedTransform.NativeMethodInfoPtr_ApplyLocale_Public_Virtual_AsyncOperationHandle_Locale_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr, 100665332);
			TrackedTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr, 100665333);
			TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr, 100665334);
			TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_1_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr, 100665335);
			TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_2_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr, 100665336);
			TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_3_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr, 100665337);
			TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_4_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr, 100665338);
			TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_5_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr, 100665339);
			TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_6_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr, 100665340);
			TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_7_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr, 100665341);
			TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_8_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr, 100665342);
			TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_9_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr, 100665343);
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00037A9C File Offset: 0x00035C9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1080907, RefRangeEnd = 1080908, XrefRangeStart = 1080814, XrefRangeEnd = 1080907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddPropertyHandlers(Dictionary<string, Action<float>> handlers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handlers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedTransform.NativeMethodInfoPtr_AddPropertyHandlers_Protected_Virtual_New_Void_Dictionary_2_String_Action_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00037AEC File Offset: 0x00035CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080908, XrefRangeEnd = 1080912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanTrackProperty(string propertyPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedTransform.NativeMethodInfoPtr_CanTrackProperty_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00037B44 File Offset: 0x00035D44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1080962, RefRangeEnd = 1080963, XrefRangeStart = 1080912, XrefRangeEnd = 1080962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variantLocale);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultLocale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedTransform.NativeMethodInfoPtr_ApplyLocale_Public_Virtual_AsyncOperationHandle_Locale_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00037BAC File Offset: 0x00035DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedTransform()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedTransform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00037BE8 File Offset: 0x00035DE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 604706, RefRangeEnd = 604707, XrefRangeStart = 604706, XrefRangeEnd = 604707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddPropertyHandlers_b__4_0(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00037C28 File Offset: 0x00035E28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 318232, RefRangeEnd = 318235, XrefRangeStart = 318232, XrefRangeEnd = 318235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddPropertyHandlers_b__4_1(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_1_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00037C68 File Offset: 0x00035E68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 318236, RefRangeEnd = 318239, XrefRangeStart = 318236, XrefRangeEnd = 318239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddPropertyHandlers_b__4_2(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_2_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00037CA8 File Offset: 0x00035EA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320619, RefRangeEnd = 320620, XrefRangeStart = 320619, XrefRangeEnd = 320620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddPropertyHandlers_b__4_3(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_3_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00037CE8 File Offset: 0x00035EE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 850305, RefRangeEnd = 850310, XrefRangeStart = 850305, XrefRangeEnd = 850310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddPropertyHandlers_b__4_4(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_4_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00037D28 File Offset: 0x00035F28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 604707, RefRangeEnd = 604708, XrefRangeStart = 604707, XrefRangeEnd = 604708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddPropertyHandlers_b__4_5(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_5_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00037D68 File Offset: 0x00035F68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 599561, RefRangeEnd = 599562, XrefRangeStart = 599561, XrefRangeEnd = 599562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddPropertyHandlers_b__4_6(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_6_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00037DA8 File Offset: 0x00035FA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 599562, RefRangeEnd = 599563, XrefRangeStart = 599562, XrefRangeEnd = 599563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddPropertyHandlers_b__4_7(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_7_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00037DE8 File Offset: 0x00035FE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318239, RefRangeEnd = 318240, XrefRangeStart = 318239, XrefRangeEnd = 318240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddPropertyHandlers_b__4_8(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_8_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00037E28 File Offset: 0x00036028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1080963, RefRangeEnd = 1080964, XrefRangeStart = 1080963, XrefRangeEnd = 1080963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddPropertyHandlers_b__4_9(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__4_9_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x000072E2 File Offset: 0x000054E2
		public TrackedTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x00037E68 File Offset: 0x00036068
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x000072EB File Offset: 0x000054EB
		public unsafe Vector3 m_PositionToApply
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedTransform.NativeFieldInfoPtr_m_PositionToApply);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedTransform.NativeFieldInfoPtr_m_PositionToApply)) = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x00037E90 File Offset: 0x00036090
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x00007306 File Offset: 0x00005506
		public unsafe Quaternion m_RotationToApply
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedTransform.NativeFieldInfoPtr_m_RotationToApply);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedTransform.NativeFieldInfoPtr_m_RotationToApply)) = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x00037EB8 File Offset: 0x000360B8
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x00007321 File Offset: 0x00005521
		public unsafe Vector3 m_ScaleToApply
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedTransform.NativeFieldInfoPtr_m_ScaleToApply);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedTransform.NativeFieldInfoPtr_m_ScaleToApply)) = value;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x00037EE0 File Offset: 0x000360E0
		// (set) Token: 0x06000C5F RID: 3167 RVA: 0x0000733C File Offset: 0x0000553C
		public unsafe Dictionary<string, Action<float>> m_PropertyHandlers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedTransform.NativeFieldInfoPtr_m_PropertyHandlers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Action<float>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedTransform.NativeFieldInfoPtr_m_PropertyHandlers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeFieldInfoPtr_m_PositionToApply;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeFieldInfoPtr_m_RotationToApply;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeFieldInfoPtr_m_ScaleToApply;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertyHandlers;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_AddPropertyHandlers_Protected_Virtual_New_Void_Dictionary_2_String_Action_1_Single_0;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeMethodInfoPtr_CanTrackProperty_Public_Virtual_Boolean_String_0;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLocale_Public_Virtual_AsyncOperationHandle_Locale_Locale_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__4_0_Private_Void_Single_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__4_1_Private_Void_Single_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__4_2_Private_Void_Single_0;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__4_3_Private_Void_Single_0;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__4_4_Private_Void_Single_0;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__4_5_Private_Void_Single_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__4_6_Private_Void_Single_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__4_7_Private_Void_Single_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__4_8_Private_Void_Single_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__4_9_Private_Void_Single_0;
	}
}
