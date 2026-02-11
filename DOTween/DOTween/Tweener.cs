using System;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace DG.Tweening
{
	// Token: 0x02000019 RID: 25
	public class Tweener : Tween
	{
		// Token: 0x0600025C RID: 604 RVA: 0x000112A4 File Offset: 0x0000F4A4
		// Note: this type is marked as 'beforefieldinit'.
		static Tweener()
		{
			Il2CppClassPointerStore<Tweener>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "Tweener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tweener>.NativeClassPtr);
			Tweener.NativeFieldInfoPtr_hasManuallySetStartValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tweener>.NativeClassPtr, "hasManuallySetStartValue");
			Tweener.NativeFieldInfoPtr_isFromAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tweener>.NativeClassPtr, "isFromAllowed");
			Tweener.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663924);
			Tweener.NativeMethodInfoPtr_ChangeStartValue_Public_Abstract_Virtual_New_Tweener_Object_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663925);
			Tweener.NativeMethodInfoPtr_ChangeEndValue_Public_Abstract_Virtual_New_Tweener_Object_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663926);
			Tweener.NativeMethodInfoPtr_ChangeEndValue_Public_Abstract_Virtual_New_Tweener_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663927);
			Tweener.NativeMethodInfoPtr_ChangeValues_Public_Abstract_Virtual_New_Tweener_Object_Object_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663928);
			Tweener.NativeMethodInfoPtr_SetFrom_Internal_Abstract_Virtual_New_Tweener_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663929);
			Tweener.NativeMethodInfoPtr_Setup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663930);
			Tweener.NativeMethodInfoPtr_DoUpdateDelay_Internal_Static_Single_TweenerCore_3_T1_T2_TPlugOptions_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663931);
			Tweener.NativeMethodInfoPtr_DoStartup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663932);
			Tweener.NativeMethodInfoPtr_DoChangeStartValue_Internal_Static_Tweener_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663933);
			Tweener.NativeMethodInfoPtr_DoChangeEndValue_Internal_Static_Tweener_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663934);
			Tweener.NativeMethodInfoPtr_DoChangeValues_Internal_Static_Tweener_TweenerCore_3_T1_T2_TPlugOptions_T2_T2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663935);
			Tweener.NativeMethodInfoPtr_DOStartupSpecials_Private_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663936);
			Tweener.NativeMethodInfoPtr_DOStartupDurationBased_Private_Static_Void_TweenerCore_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663937);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00011414 File Offset: 0x0000F614
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1131667, RefRangeEnd = 1131669, XrefRangeStart = 1131666, XrefRangeEnd = 1131667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tweener()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tweener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tweener.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00011450 File Offset: 0x0000F650
		[CallerCount(0)]
		public unsafe virtual Tweener ChangeStartValue(Object newStartValue, float newDuration = -1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newStartValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tweener.NativeMethodInfoPtr_ChangeStartValue_Public_Abstract_Virtual_New_Tweener_Object_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000114BC File Offset: 0x0000F6BC
		[CallerCount(0)]
		public unsafe virtual Tweener ChangeEndValue(Object newEndValue, float newDuration = -1f, bool snapStartValue = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newEndValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDuration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapStartValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tweener.NativeMethodInfoPtr_ChangeEndValue_Public_Abstract_Virtual_New_Tweener_Object_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00011534 File Offset: 0x0000F734
		[CallerCount(0)]
		public unsafe virtual Tweener ChangeEndValue(Object newEndValue, bool snapStartValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newEndValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapStartValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tweener.NativeMethodInfoPtr_ChangeEndValue_Public_Abstract_Virtual_New_Tweener_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000115A0 File Offset: 0x0000F7A0
		[CallerCount(0)]
		public unsafe virtual Tweener ChangeValues(Object newStartValue, Object newEndValue, float newDuration = -1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newStartValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newEndValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tweener.NativeMethodInfoPtr_ChangeValues_Public_Abstract_Virtual_New_Tweener_Object_Object_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0001161C File Offset: 0x0000F81C
		[CallerCount(0)]
		public unsafe virtual Tweener SetFrom(bool relative)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref relative;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tweener.NativeMethodInfoPtr_SetFrom_Internal_Abstract_Virtual_New_Tweener_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00011674 File Offset: 0x0000F874
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1131676, RefRangeEnd = 1131678, XrefRangeStart = 1131669, XrefRangeEnd = 1131676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Setup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null) where TPlugOptions : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = endValue;
				intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref endValue;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(plugin);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Tweener.MethodInfoStoreGeneric_Setup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00011744 File Offset: 0x0000F944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1131678, RefRangeEnd = 1131679, XrefRangeStart = 1131678, XrefRangeEnd = 1131678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float DoUpdateDelay<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, float elapsed) where TPlugOptions : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tweener.MethodInfoStoreGeneric_DoUpdateDelay_Internal_Static_Single_TweenerCore_3_T1_T2_TPlugOptions_Single_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00011794 File Offset: 0x0000F994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1131686, RefRangeEnd = 1131687, XrefRangeStart = 1131679, XrefRangeEnd = 1131686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoStartup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tweener.MethodInfoStoreGeneric_DoStartup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000117D8 File Offset: 0x0000F9D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1131689, RefRangeEnd = 1131690, XrefRangeStart = 1131687, XrefRangeEnd = 1131689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DoChangeStartValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration) where TPlugOptions : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = newStartValue;
				intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref newStartValue;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDuration;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Tweener.MethodInfoStoreGeneric_DoChangeStartValue_Internal_Static_Tweener_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr4) : null;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00011874 File Offset: 0x0000FA74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1131698, RefRangeEnd = 1131699, XrefRangeStart = 1131690, XrefRangeEnd = 1131698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DoChangeEndValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue) where TPlugOptions : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = newEndValue;
				intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref newEndValue;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDuration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapStartValue;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Tweener.MethodInfoStoreGeneric_DoChangeEndValue_Internal_Static_Tweener_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_Boolean_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr4) : null;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0001191C File Offset: 0x0000FB1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1131701, RefRangeEnd = 1131702, XrefRangeStart = 1131699, XrefRangeEnd = 1131701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DoChangeValues<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration) where TPlugOptions : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = newStartValue;
				intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref newStartValue;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = newEndValue;
				intPtr2 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref newEndValue;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDuration;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Tweener.MethodInfoStoreGeneric_DoChangeValues_Internal_Static_Tweener_TweenerCore_3_T1_T2_TPlugOptions_T2_T2_Single_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr5) : null;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00011A00 File Offset: 0x0000FC00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1131721, RefRangeEnd = 1131725, XrefRangeStart = 1131702, XrefRangeEnd = 1131721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DOStartupSpecials<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tweener.MethodInfoStoreGeneric_DOStartupSpecials_Private_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00011A44 File Offset: 0x0000FC44
		[CallerCount(0)]
		public unsafe static void DOStartupDurationBased<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tweener.MethodInfoStoreGeneric_DOStartupDurationBased_Private_Static_Void_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002B7D File Offset: 0x00000D7D
		public Tweener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00011A7C File Offset: 0x0000FC7C
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00002B86 File Offset: 0x00000D86
		public unsafe bool hasManuallySetStartValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tweener.NativeFieldInfoPtr_hasManuallySetStartValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tweener.NativeFieldInfoPtr_hasManuallySetStartValue)) = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00011AA4 File Offset: 0x0000FCA4
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00002BA1 File Offset: 0x00000DA1
		public unsafe bool isFromAllowed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tweener.NativeFieldInfoPtr_isFromAllowed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tweener.NativeFieldInfoPtr_isFromAllowed)) = value;
			}
		}

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeFieldInfoPtr_hasManuallySetStartValue;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeFieldInfoPtr_isFromAllowed;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_ChangeStartValue_Public_Abstract_Virtual_New_Tweener_Object_Single_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_ChangeEndValue_Public_Abstract_Virtual_New_Tweener_Object_Single_Boolean_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_ChangeEndValue_Public_Abstract_Virtual_New_Tweener_Object_Boolean_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_ChangeValues_Public_Abstract_Virtual_New_Tweener_Object_Object_Single_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_SetFrom_Internal_Abstract_Virtual_New_Tweener_Boolean_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_DoUpdateDelay_Internal_Static_Single_TweenerCore_3_T1_T2_TPlugOptions_Single_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_DoStartup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_DoChangeStartValue_Internal_Static_Tweener_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_DoChangeEndValue_Internal_Static_Tweener_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_Boolean_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_DoChangeValues_Internal_Static_Tweener_TweenerCore_3_T1_T2_TPlugOptions_T2_T2_Single_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_DOStartupSpecials_Private_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_DOStartupDurationBased_Private_Static_Void_TweenerCore_3_T1_T2_TPlugOptions_0;

		// Token: 0x020000DC RID: 220
		private sealed class MethodInfoStoreGeneric_Setup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>
		{
			// Token: 0x040005FF RID: 1535
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tweener.NativeMethodInfoPtr_Setup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<Tweener>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000DD RID: 221
		private sealed class MethodInfoStoreGeneric_DoUpdateDelay_Internal_Static_Single_TweenerCore_3_T1_T2_TPlugOptions_Single_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000600 RID: 1536
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tweener.NativeMethodInfoPtr_DoUpdateDelay_Internal_Static_Single_TweenerCore_3_T1_T2_TPlugOptions_Single_0, Il2CppClassPointerStore<Tweener>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000DE RID: 222
		private sealed class MethodInfoStoreGeneric_DoStartup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000601 RID: 1537
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tweener.NativeMethodInfoPtr_DoStartup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<Tweener>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000DF RID: 223
		private sealed class MethodInfoStoreGeneric_DoChangeStartValue_Internal_Static_Tweener_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000602 RID: 1538
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tweener.NativeMethodInfoPtr_DoChangeStartValue_Internal_Static_Tweener_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_0, Il2CppClassPointerStore<Tweener>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000E0 RID: 224
		private sealed class MethodInfoStoreGeneric_DoChangeEndValue_Internal_Static_Tweener_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_Boolean_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000603 RID: 1539
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tweener.NativeMethodInfoPtr_DoChangeEndValue_Internal_Static_Tweener_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_Boolean_0, Il2CppClassPointerStore<Tweener>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000E1 RID: 225
		private sealed class MethodInfoStoreGeneric_DoChangeValues_Internal_Static_Tweener_TweenerCore_3_T1_T2_TPlugOptions_T2_T2_Single_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000604 RID: 1540
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tweener.NativeMethodInfoPtr_DoChangeValues_Internal_Static_Tweener_TweenerCore_3_T1_T2_TPlugOptions_T2_T2_Single_0, Il2CppClassPointerStore<Tweener>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000E2 RID: 226
		private sealed class MethodInfoStoreGeneric_DOStartupSpecials_Private_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000605 RID: 1541
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tweener.NativeMethodInfoPtr_DOStartupSpecials_Private_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<Tweener>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000E3 RID: 227
		private sealed class MethodInfoStoreGeneric_DOStartupDurationBased_Private_Static_Void_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000606 RID: 1542
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tweener.NativeMethodInfoPtr_DOStartupDurationBased_Private_Static_Void_TweenerCore_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<Tweener>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}
	}
}
