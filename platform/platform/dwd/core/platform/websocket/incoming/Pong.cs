using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.incoming
{
	// Token: 0x0200003C RID: 60
	public class Pong : TypedMessage
	{
		// Token: 0x06000208 RID: 520 RVA: 0x0000BC5C File Offset: 0x00009E5C
		// Note: this type is marked as 'beforefieldinit'.
		static Pong()
		{
			Il2CppClassPointerStore<Pong>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.incoming", "Pong");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pong>.NativeClassPtr);
			Pong.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "Time");
			Pong.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100663621);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000BCB4 File Offset: 0x00009EB4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pong()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pong>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000305E File Offset: 0x0000125E
		public Pong(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0000BCF0 File Offset: 0x00009EF0
		// (set) Token: 0x0600020C RID: 524 RVA: 0x00003067 File Offset: 0x00001267
		public unsafe long Time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_Time)) = value;
			}
		}

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr_Time;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
