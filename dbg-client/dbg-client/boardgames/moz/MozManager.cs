using System;
using boardgames.input;
using dwd.core;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.moz
{
	// Token: 0x0200011D RID: 285
	public class MozManager : MonoBehaviour
	{
		// Token: 0x06000CB1 RID: 3249 RVA: 0x000458F0 File Offset: 0x00043AF0
		// Note: this type is marked as 'beforefieldinit'.
		static MozManager()
		{
			Il2CppClassPointerStore<MozManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "MozManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MozManager>.NativeClassPtr);
			MozManager.NativeFieldInfoPtr_allMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozManager>.NativeClassPtr, "allMoz");
			MozManager.NativeFieldInfoPtr_resetDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozManager>.NativeClassPtr, "resetDelay");
			MozManager.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozManager>.NativeClassPtr, "current");
			MozManager.NativeFieldInfoPtr_transitionScaler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozManager>.NativeClassPtr, "transitionScaler");
			MozManager.NativeFieldInfoPtr_enableRapidTransitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozManager>.NativeClassPtr, "enableRapidTransitions");
			MozManager.NativeFieldInfoPtr_onPrepareToMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozManager>.NativeClassPtr, "onPrepareToMoz");
			MozManager.NativeFieldInfoPtr_onMozBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozManager>.NativeClassPtr, "onMozBegin");
			MozManager.NativeFieldInfoPtr_onMozEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozManager>.NativeClassPtr, "onMozEnd");
			MozManager.NativeFieldInfoPtr__IsMozEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozManager>.NativeClassPtr, "<IsMozEnabled>k__BackingField");
			MozManager.NativeFieldInfoPtr_mozDisabledSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozManager>.NativeClassPtr, "mozDisabledSources");
			MozManager.NativeFieldInfoPtr_overriddenMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozManager>.NativeClassPtr, "overriddenMoz");
			MozManager.NativeMethodInfoPtr_get_TransitionScaler_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozManager>.NativeClassPtr, 100665144);
			MozManager.NativeMethodInfoPtr_get_OnPrepareToMoz_Public_get_UnityEventString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozManager>.NativeClassPtr, 100665145);
			MozManager.NativeMethodInfoPtr_get_OnMozBegin_Public_get_UnityEventString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozManager>.NativeClassPtr, 100665146);
			MozManager.NativeMethodInfoPtr_get_OnMozEnd_Public_get_UnityEventString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozManager>.NativeClassPtr, 100665147);
			MozManager.NativeMethodInfoPtr_get_IsMozEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozManager>.NativeClassPtr, 100665148);
			MozManager.NativeMethodInfoPtr_set_IsMozEnabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozManager>.NativeClassPtr, 100665149);
			MozManager.NativeMethodInfoPtr_get_AnyMozActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozManager>.NativeClassPtr, 100665150);
			MozManager.NativeMethodInfoPtr_RegisterMoz_Public_Void_BaseMoz_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozManager>.NativeClassPtr, 100665151);
			MozManager.NativeMethodInfoPtr_UnregisterMoz_Public_Void_BaseMoz_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozManager>.NativeClassPtr, 100665152);
			MozManager.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozManager>.NativeClassPtr, 100665153);
			MozManager.NativeMethodInfoPtr_EnableMoz_Public_Void_IMozDisabler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozManager>.NativeClassPtr, 100665154);
			MozManager.NativeMethodInfoPtr_DisableMoz_Public_Void_IMozDisabler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozManager>.NativeClassPtr, 100665155);
			MozManager.NativeMethodInfoPtr_ClearMoz_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozManager>.NativeClassPtr, 100665156);
			MozManager.NativeMethodInfoPtr_SetCurrent_Public_Void_BaseMoz_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozManager>.NativeClassPtr, 100665157);
			MozManager.NativeMethodInfoPtr_restoreOverriddenMoz_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozManager>.NativeClassPtr, 100665158);
			MozManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozManager>.NativeClassPtr, 100665159);
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x00045B3C File Offset: 0x00043D3C
		public unsafe float TransitionScaler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozManager.NativeMethodInfoPtr_get_TransitionScaler_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00045B78 File Offset: 0x00043D78
		public unsafe UnityEventString OnPrepareToMoz
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozManager.NativeMethodInfoPtr_get_OnPrepareToMoz_Public_get_UnityEventString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEventString>(intPtr3) : null;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x00045BB8 File Offset: 0x00043DB8
		public unsafe UnityEventString OnMozBegin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozManager.NativeMethodInfoPtr_get_OnMozBegin_Public_get_UnityEventString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEventString>(intPtr3) : null;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00045BF8 File Offset: 0x00043DF8
		public unsafe UnityEventString OnMozEnd
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozManager.NativeMethodInfoPtr_get_OnMozEnd_Public_get_UnityEventString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEventString>(intPtr3) : null;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x00045C38 File Offset: 0x00043E38
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x00045C74 File Offset: 0x00043E74
		public unsafe bool IsMozEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozManager.NativeMethodInfoPtr_get_IsMozEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozManager.NativeMethodInfoPtr_set_IsMozEnabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00045CB4 File Offset: 0x00043EB4
		public unsafe bool AnyMozActive
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 510095, RefRangeEnd = 510096, XrefRangeStart = 510077, XrefRangeEnd = 510095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozManager.NativeMethodInfoPtr_get_AnyMozActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x00045CF0 File Offset: 0x00043EF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510111, RefRangeEnd = 510112, XrefRangeStart = 510096, XrefRangeEnd = 510111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterMoz(BaseMoz moz)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(moz);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozManager.NativeMethodInfoPtr_RegisterMoz_Public_Void_BaseMoz_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00045D34 File Offset: 0x00043F34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510125, RefRangeEnd = 510126, XrefRangeStart = 510112, XrefRangeEnd = 510125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterMoz(BaseMoz moz)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(moz);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozManager.NativeMethodInfoPtr_UnregisterMoz_Public_Void_BaseMoz_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00045D78 File Offset: 0x00043F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510126, XrefRangeEnd = 510154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozManager.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00045DAC File Offset: 0x00043FAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510160, RefRangeEnd = 510161, XrefRangeStart = 510154, XrefRangeEnd = 510160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableMoz(IMozDisabler mozEnabledSource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mozEnabledSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozManager.NativeMethodInfoPtr_EnableMoz_Public_Void_IMozDisabler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00045DF0 File Offset: 0x00043FF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510165, RefRangeEnd = 510166, XrefRangeStart = 510161, XrefRangeEnd = 510165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableMoz(IMozDisabler mozDisabledSource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mozDisabledSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozManager.NativeMethodInfoPtr_DisableMoz_Public_Void_IMozDisabler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x00045E34 File Offset: 0x00044034
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 510189, RefRangeEnd = 510191, XrefRangeStart = 510166, XrefRangeEnd = 510189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozManager.NativeMethodInfoPtr_ClearMoz_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00045E68 File Offset: 0x00044068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510219, RefRangeEnd = 510220, XrefRangeStart = 510191, XrefRangeEnd = 510219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurrent(BaseMoz moz)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(moz);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozManager.NativeMethodInfoPtr_SetCurrent_Public_Void_BaseMoz_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00045EAC File Offset: 0x000440AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510220, XrefRangeEnd = 510243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void restoreOverriddenMoz(string irrelevant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(irrelevant);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozManager.NativeMethodInfoPtr_restoreOverriddenMoz_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00045EF0 File Offset: 0x000440F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510243, XrefRangeEnd = 510271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MozManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MozManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x000082A2 File Offset: 0x000064A2
		public MozManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x00045F2C File Offset: 0x0004412C
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x000082AB File Offset: 0x000064AB
		public unsafe List<BaseMoz> allMoz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_allMoz);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseMoz>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_allMoz), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x00045F5C File Offset: 0x0004415C
		// (set) Token: 0x06000CC6 RID: 3270 RVA: 0x000082CA File Offset: 0x000064CA
		public unsafe float resetDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_resetDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_resetDelay)) = value;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x00045F84 File Offset: 0x00044184
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x000082E5 File Offset: 0x000064E5
		public unsafe BaseMoz current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseMoz>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x00045FB4 File Offset: 0x000441B4
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x00008304 File Offset: 0x00006504
		public unsafe float transitionScaler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_transitionScaler);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_transitionScaler)) = value;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00045FDC File Offset: 0x000441DC
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x0000831F File Offset: 0x0000651F
		public unsafe bool enableRapidTransitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_enableRapidTransitions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_enableRapidTransitions)) = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x00046004 File Offset: 0x00044204
		// (set) Token: 0x06000CCE RID: 3278 RVA: 0x0000833A File Offset: 0x0000653A
		public unsafe UnityEventString onPrepareToMoz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_onPrepareToMoz);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_onPrepareToMoz), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x00046034 File Offset: 0x00044234
		// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x00008359 File Offset: 0x00006559
		public unsafe UnityEventString onMozBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_onMozBegin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_onMozBegin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x00046064 File Offset: 0x00044264
		// (set) Token: 0x06000CD2 RID: 3282 RVA: 0x00008378 File Offset: 0x00006578
		public unsafe UnityEventString onMozEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_onMozEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_onMozEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x00046094 File Offset: 0x00044294
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x00008397 File Offset: 0x00006597
		public unsafe bool _IsMozEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr__IsMozEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr__IsMozEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x000460BC File Offset: 0x000442BC
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x000083B2 File Offset: 0x000065B2
		public unsafe Disabler<IMozDisabler> mozDisabledSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_mozDisabledSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Disabler<IMozDisabler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_mozDisabledSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x000460EC File Offset: 0x000442EC
		// (set) Token: 0x06000CD8 RID: 3288 RVA: 0x000083D1 File Offset: 0x000065D1
		public unsafe BaseMoz overriddenMoz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_overriddenMoz);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseMoz>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozManager.NativeFieldInfoPtr_overriddenMoz), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeFieldInfoPtr_allMoz;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeFieldInfoPtr_resetDelay;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeFieldInfoPtr_transitionScaler;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeFieldInfoPtr_enableRapidTransitions;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeFieldInfoPtr_onPrepareToMoz;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeFieldInfoPtr_onMozBegin;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeFieldInfoPtr_onMozEnd;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeFieldInfoPtr__IsMozEnabled_k__BackingField;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeFieldInfoPtr_mozDisabledSources;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeFieldInfoPtr_overriddenMoz;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_get_TransitionScaler_Public_get_Single_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_get_OnPrepareToMoz_Public_get_UnityEventString_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_get_OnMozBegin_Public_get_UnityEventString_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_get_OnMozEnd_Public_get_UnityEventString_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMozEnabled_Public_get_Boolean_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMozEnabled_Private_set_Void_Boolean_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyMozActive_Public_get_Boolean_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_RegisterMoz_Public_Void_BaseMoz_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterMoz_Public_Void_BaseMoz_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_EnableMoz_Public_Void_IMozDisabler_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_DisableMoz_Public_Void_IMozDisabler_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_ClearMoz_Public_Void_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrent_Public_Void_BaseMoz_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_restoreOverriddenMoz_Private_Void_String_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000353 RID: 851
		[ObfuscatedName("boardgames.moz.MozManager+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002830 RID: 10288 RVA: 0x000A0CF4 File Offset: 0x0009EEF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MozManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MozManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MozManager.__c>.NativeClassPtr);
				MozManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozManager.__c>.NativeClassPtr, "<>9");
				MozManager.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozManager.__c>.NativeClassPtr, "<>9__22_0");
				MozManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozManager.__c>.NativeClassPtr, 100665161);
				MozManager.__c.NativeMethodInfoPtr__get_AnyMozActive_b__22_0_Internal_Boolean_BaseMoz_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozManager.__c>.NativeClassPtr, 100665162);
			}

			// Token: 0x06002831 RID: 10289 RVA: 0x000A0D70 File Offset: 0x0009EF70
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MozManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002832 RID: 10290 RVA: 0x000A0DAC File Offset: 0x0009EFAC
			[CallerCount(0)]
			public unsafe bool _get_AnyMozActive_b__22_0(BaseMoz m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozManager.__c.NativeMethodInfoPtr__get_AnyMozActive_b__22_0_Internal_Boolean_BaseMoz_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002833 RID: 10291 RVA: 0x00014C8C File Offset: 0x00012E8C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B3D RID: 2877
			// (get) Token: 0x06002834 RID: 10292 RVA: 0x000A0DFC File Offset: 0x0009EFFC
			// (set) Token: 0x06002835 RID: 10293 RVA: 0x00014C95 File Offset: 0x00012E95
			public unsafe static MozManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MozManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MozManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MozManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B3E RID: 2878
			// (get) Token: 0x06002836 RID: 10294 RVA: 0x000A0E24 File Offset: 0x0009F024
			// (set) Token: 0x06002837 RID: 10295 RVA: 0x00014CA7 File Offset: 0x00012EA7
			public unsafe static Func<BaseMoz, bool> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MozManager.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BaseMoz, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MozManager.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001932 RID: 6450
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001933 RID: 6451
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x04001934 RID: 6452
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001935 RID: 6453
			private static readonly IntPtr NativeMethodInfoPtr__get_AnyMozActive_b__22_0_Internal_Boolean_BaseMoz_0;
		}
	}
}
