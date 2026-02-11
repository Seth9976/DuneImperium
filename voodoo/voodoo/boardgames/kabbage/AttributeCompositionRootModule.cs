using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace boardgames.kabbage
{
	// Token: 0x02000091 RID: 145
	public class AttributeCompositionRootModule : MonoBehaviour
	{
		// Token: 0x06000899 RID: 2201 RVA: 0x00026118 File Offset: 0x00024318
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeCompositionRootModule()
		{
			Il2CppClassPointerStore<AttributeCompositionRootModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.kabbage", "AttributeCompositionRootModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeCompositionRootModule>.NativeClassPtr);
			AttributeCompositionRootModule.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeCompositionRootModule>.NativeClassPtr, "attributes");
			AttributeCompositionRootModule.NativeMethodInfoPtr_get_Attributes_Public_get_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeCompositionRootModule>.NativeClassPtr, 100664548);
			AttributeCompositionRootModule.NativeMethodInfoPtr_Configure_Public_Virtual_Final_New_Void_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeCompositionRootModule>.NativeClassPtr, 100664549);
			AttributeCompositionRootModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeCompositionRootModule>.NativeClassPtr, 100664550);
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00026198 File Offset: 0x00024398
		public unsafe ReadOnlyAttributes Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeCompositionRootModule.NativeMethodInfoPtr_get_Attributes_Public_get_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x000261D8 File Offset: 0x000243D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116515, XrefRangeEnd = 1116517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Configure(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeCompositionRootModule.NativeMethodInfoPtr_Configure_Public_Virtual_Final_New_Void_MoveContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0002621C File Offset: 0x0002441C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeCompositionRootModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeCompositionRootModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeCompositionRootModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0000631F File Offset: 0x0000451F
		public AttributeCompositionRootModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x00026258 File Offset: 0x00024458
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x00006328 File Offset: 0x00004528
		public unsafe ReadOnlyAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCompositionRootModule.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCompositionRootModule.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_ReadOnlyAttributes_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_Final_New_Void_MoveContext_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
