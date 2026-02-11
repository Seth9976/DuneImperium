using System;
using boardgames.match.tutorial;
using Canis.attributes;
using dwd.core.commands;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm
{
	// Token: 0x0200005A RID: 90
	public class WormTutorialEffects : TutorialEffects
	{
		// Token: 0x0600039C RID: 924 RVA: 0x00024458 File Offset: 0x00022658
		// Note: this type is marked as 'beforefieldinit'.
		static WormTutorialEffects()
		{
			Il2CppClassPointerStore<WormTutorialEffects>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormTutorialEffects");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialEffects>.NativeClassPtr);
			WormTutorialEffects.NativeMethodInfoPtr_ShowPrompt_Public_Virtual_Command_DataComposition_String_Nullable_1_Int32_String_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialEffects>.NativeClassPtr, 100663899);
			WormTutorialEffects.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialEffects>.NativeClassPtr, 100663900);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000244B0 File Offset: 0x000226B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692924, XrefRangeEnd = 692945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Command ShowPrompt(DataComposition promptData, string dialogType, Nullable<int> tutorialID = null, string dialogScope = "", MutableAttributes attributes = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tutorialID));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogScope);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTutorialEffects.NativeMethodInfoPtr_ShowPrompt_Public_Virtual_Command_DataComposition_String_Nullable_1_Int32_String_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0002455C File Offset: 0x0002275C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692945, XrefRangeEnd = 692946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialEffects()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialEffects>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialEffects.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000039BB File Offset: 0x00001BBB
		public WormTutorialEffects(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_ShowPrompt_Public_Virtual_Command_DataComposition_String_Nullable_1_Int32_String_MutableAttributes_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
