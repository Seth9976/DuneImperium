using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace boardgames.menus.prompts
{
	// Token: 0x020001DC RID: 476
	public class SerializedMatchDataProvider : MonoBehaviour
	{
		// Token: 0x06001604 RID: 5636 RVA: 0x000649DC File Offset: 0x00062BDC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedMatchDataProvider()
		{
			Il2CppClassPointerStore<SerializedMatchDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "SerializedMatchDataProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedMatchDataProvider>.NativeClassPtr);
			SerializedMatchDataProvider.NativeFieldInfoPtr_scenarioName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedMatchDataProvider>.NativeClassPtr, "scenarioName");
			SerializedMatchDataProvider.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMatchDataProvider>.NativeClassPtr, 100666514);
			SerializedMatchDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMatchDataProvider>.NativeClassPtr, 100666515);
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00064A48 File Offset: 0x00062C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523356, XrefRangeEnd = 523379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMatchDataProvider.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00064A7C File Offset: 0x00062C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523379, XrefRangeEnd = 523383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedMatchDataProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedMatchDataProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMatchDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x0000C76B File Offset: 0x0000A96B
		public SerializedMatchDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x00064AB8 File Offset: 0x00062CB8
		// (set) Token: 0x06001609 RID: 5641 RVA: 0x0000C774 File Offset: 0x0000A974
		public unsafe string scenarioName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMatchDataProvider.NativeFieldInfoPtr_scenarioName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMatchDataProvider.NativeFieldInfoPtr_scenarioName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeFieldInfoPtr_scenarioName;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
