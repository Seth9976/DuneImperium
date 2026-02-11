using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Networking.service
{
	// Token: 0x02000050 RID: 80
	public class FlushPendingMessages : NetworkMessageEvent
	{
		// Token: 0x0600029A RID: 666 RVA: 0x0000C8DC File Offset: 0x0000AADC
		// Note: this type is marked as 'beforefieldinit'.
		static FlushPendingMessages()
		{
			Il2CppClassPointerStore<FlushPendingMessages>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.service", "FlushPendingMessages");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlushPendingMessages>.NativeClassPtr);
			FlushPendingMessages.NativeFieldInfoPtr_sendEmptyBundle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlushPendingMessages>.NativeClassPtr, "sendEmptyBundle");
			FlushPendingMessages.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlushPendingMessages>.NativeClassPtr, 100663429);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000C934 File Offset: 0x0000AB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193832, XrefRangeEnd = 1193833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlushPendingMessages()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlushPendingMessages>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlushPendingMessages.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00003B24 File Offset: 0x00001D24
		public FlushPendingMessages(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0000C970 File Offset: 0x0000AB70
		// (set) Token: 0x0600029E RID: 670 RVA: 0x00003B2D File Offset: 0x00001D2D
		public unsafe bool sendEmptyBundle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushPendingMessages.NativeFieldInfoPtr_sendEmptyBundle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushPendingMessages.NativeFieldInfoPtr_sendEmptyBundle)) = value;
			}
		}

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr_sendEmptyBundle;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
