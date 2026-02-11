using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Networking.eventtriggers.clientactions;

namespace Canis.messages
{
	// Token: 0x02000166 RID: 358
	public class ShowCutScene : ClientAction
	{
		// Token: 0x06001019 RID: 4121 RVA: 0x0005AB6C File Offset: 0x00058D6C
		// Note: this type is marked as 'beforefieldinit'.
		static ShowCutScene()
		{
			Il2CppClassPointerStore<ShowCutScene>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.messages", "ShowCutScene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowCutScene>.NativeClassPtr);
			ShowCutScene.NativeFieldInfoPtr_CutSceneKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowCutScene>.NativeClassPtr, "CutSceneKey");
			ShowCutScene.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowCutScene>.NativeClassPtr, 100666580);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x0005ABC4 File Offset: 0x00058DC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 578945, RefRangeEnd = 578947, XrefRangeStart = 578943, XrefRangeEnd = 578945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShowCutScene(string key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowCutScene>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowCutScene.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x0000837A File Offset: 0x0000657A
		public ShowCutScene(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x0005AC10 File Offset: 0x00058E10
		// (set) Token: 0x0600101D RID: 4125 RVA: 0x00008383 File Offset: 0x00006583
		public unsafe string CutSceneKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowCutScene.NativeFieldInfoPtr_CutSceneKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowCutScene.NativeFieldInfoPtr_CutSceneKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeFieldInfoPtr_CutSceneKey;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
