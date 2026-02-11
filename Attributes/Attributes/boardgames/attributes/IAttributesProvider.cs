using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace boardgames.attributes
{
	// Token: 0x02000008 RID: 8
	public class IAttributesProvider : Il2CppObjectBase
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00003B40 File Offset: 0x00001D40
		// Note: this type is marked as 'beforefieldinit'.
		static IAttributesProvider()
		{
			Il2CppClassPointerStore<IAttributesProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "boardgames.attributes", "IAttributesProvider");
			IAttributesProvider.NativeMethodInfoPtr_GetAttributes_Public_Abstract_Virtual_New_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttributesProvider>.NativeClassPtr, 100663306);
			IAttributesProvider.NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_New_IEnumerable_1_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttributesProvider>.NativeClassPtr, 100663307);
			IAttributesProvider.NativeMethodInfoPtr_RegisterOnAttributesChanged_Public_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttributesProvider>.NativeClassPtr, 100663308);
			IAttributesProvider.NativeMethodInfoPtr_UnregisterOnAttributesChanged_Public_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttributesProvider>.NativeClassPtr, 100663309);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[CallerCount(0)]
		public unsafe virtual IHasAttributes GetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttributesProvider.NativeMethodInfoPtr_GetAttributes_Public_Abstract_Virtual_New_IHasAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr3) : null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003C04 File Offset: 0x00001E04
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<IAttributeDefinition> ProvidesAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttributesProvider.NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_New_IEnumerable_1_IAttributeDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttributeDefinition>>(intPtr3) : null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003C50 File Offset: 0x00001E50
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RegisterOnAttributesChanged(Action changedHandler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(changedHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttributesProvider.NativeMethodInfoPtr_RegisterOnAttributesChanged_Public_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003CA0 File Offset: 0x00001EA0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnregisterOnAttributesChanged(Action changedHandler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(changedHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttributesProvider.NativeMethodInfoPtr_UnregisterOnAttributesChanged_Public_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000218B File Offset: 0x0000038B
		public IAttributesProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Abstract_Virtual_New_IHasAttributes_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_New_IEnumerable_1_IAttributeDefinition_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_RegisterOnAttributesChanged_Public_Virtual_New_Void_Action_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterOnAttributesChanged_Public_Virtual_New_Void_Action_0;
	}
}
