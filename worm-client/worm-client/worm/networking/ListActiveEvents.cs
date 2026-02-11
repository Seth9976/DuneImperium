using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.networking
{
	// Token: 0x02000061 RID: 97
	public class ListActiveEvents : NetworkMessageEvent
	{
		// Token: 0x060003C5 RID: 965 RVA: 0x00003A76 File Offset: 0x00001C76
		// Note: this type is marked as 'beforefieldinit'.
		static ListActiveEvents()
		{
			Il2CppClassPointerStore<ListActiveEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking", "ListActiveEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListActiveEvents>.NativeClassPtr);
			ListActiveEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListActiveEvents>.NativeClassPtr, 100663918);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00024D90 File Offset: 0x00022F90
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListActiveEvents()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListActiveEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListActiveEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00003AAF File Offset: 0x00001CAF
		public ListActiveEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
