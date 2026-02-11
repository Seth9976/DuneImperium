using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace boardgames.attributes.providers
{
	// Token: 0x0200016D RID: 365
	public class GenericAttributesProvider : MonoBehaviour
	{
		// Token: 0x06001270 RID: 4720 RVA: 0x00049B84 File Offset: 0x00047D84
		// Note: this type is marked as 'beforefieldinit'.
		static GenericAttributesProvider()
		{
			Il2CppClassPointerStore<GenericAttributesProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes.providers", "GenericAttributesProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericAttributesProvider>.NativeClassPtr);
			GenericAttributesProvider.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericAttributesProvider>.NativeClassPtr, "attributes");
			GenericAttributesProvider.NativeFieldInfoPtr_OnAttributesChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericAttributesProvider>.NativeClassPtr, "OnAttributesChanged");
			GenericAttributesProvider.NativeMethodInfoPtr_add_OnAttributesChanged_Private_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericAttributesProvider>.NativeClassPtr, 100665994);
			GenericAttributesProvider.NativeMethodInfoPtr_remove_OnAttributesChanged_Private_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericAttributesProvider>.NativeClassPtr, 100665995);
			GenericAttributesProvider.NativeMethodInfoPtr_SetAttributes_Public_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericAttributesProvider>.NativeClassPtr, 100665996);
			GenericAttributesProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericAttributesProvider>.NativeClassPtr, 100665997);
			GenericAttributesProvider.NativeMethodInfoPtr_RegisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericAttributesProvider>.NativeClassPtr, 100665998);
			GenericAttributesProvider.NativeMethodInfoPtr_UnregisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericAttributesProvider>.NativeClassPtr, 100665999);
			GenericAttributesProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericAttributesProvider>.NativeClassPtr, 100666000);
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00049C68 File Offset: 0x00047E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000951, XrefRangeEnd = 1000955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnAttributesChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericAttributesProvider.NativeMethodInfoPtr_add_OnAttributesChanged_Private_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00049CAC File Offset: 0x00047EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000955, XrefRangeEnd = 1000959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnAttributesChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericAttributesProvider.NativeMethodInfoPtr_remove_OnAttributesChanged_Private_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00049CF0 File Offset: 0x00047EF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1000960, RefRangeEnd = 1000963, XrefRangeStart = 1000959, XrefRangeEnd = 1000960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAttributes(IHasAttributes newAttributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newAttributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericAttributesProvider.NativeMethodInfoPtr_SetAttributes_Public_Void_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x00049D34 File Offset: 0x00047F34
		[CallerCount(0)]
		public unsafe virtual IHasAttributes GetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericAttributesProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr3) : null;
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x00049D74 File Offset: 0x00047F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RegisterOnAttributesChanged(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericAttributesProvider.NativeMethodInfoPtr_RegisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00049DB8 File Offset: 0x00047FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnregisterOnAttributesChanged(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericAttributesProvider.NativeMethodInfoPtr_UnregisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00049DFC File Offset: 0x00047FFC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericAttributesProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericAttributesProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericAttributesProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x0000A9D1 File Offset: 0x00008BD1
		public GenericAttributesProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x00049E38 File Offset: 0x00048038
		// (set) Token: 0x0600127A RID: 4730 RVA: 0x0000A9DA File Offset: 0x00008BDA
		public unsafe IHasAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericAttributesProvider.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericAttributesProvider.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x00049E68 File Offset: 0x00048068
		// (set) Token: 0x0600127C RID: 4732 RVA: 0x0000A9F9 File Offset: 0x00008BF9
		public unsafe Action OnAttributesChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericAttributesProvider.NativeFieldInfoPtr_OnAttributesChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericAttributesProvider.NativeFieldInfoPtr_OnAttributesChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeFieldInfoPtr_OnAttributesChanged;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_add_OnAttributesChanged_Private_add_Void_Action_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnAttributesChanged_Private_rem_Void_Action_0;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributes_Public_Void_IHasAttributes_0;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeMethodInfoPtr_RegisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
