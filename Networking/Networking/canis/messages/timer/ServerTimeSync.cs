using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Canis.messages.timer
{
	// Token: 0x02000039 RID: 57
	public class ServerTimeSync : NetworkMessageEvent
	{
		// Token: 0x060001E0 RID: 480 RVA: 0x0000AADC File Offset: 0x00008CDC
		// Note: this type is marked as 'beforefieldinit'.
		static ServerTimeSync()
		{
			Il2CppClassPointerStore<ServerTimeSync>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.timer", "ServerTimeSync");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerTimeSync>.NativeClassPtr);
			ServerTimeSync.NativeFieldInfoPtr_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerTimeSync>.NativeClassPtr, "ServerTime");
			ServerTimeSync.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerTimeSync>.NativeClassPtr, 100663389);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000AB34 File Offset: 0x00008D34
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerTimeSync()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerTimeSync>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerTimeSync.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00003489 File Offset: 0x00001689
		public ServerTimeSync(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000AB70 File Offset: 0x00008D70
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00003492 File Offset: 0x00001692
		public unsafe long ServerTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerTimeSync.NativeFieldInfoPtr_ServerTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerTimeSync.NativeFieldInfoPtr_ServerTime)) = value;
			}
		}

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr_ServerTime;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
