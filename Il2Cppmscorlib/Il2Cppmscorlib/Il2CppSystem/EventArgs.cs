using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200008E RID: 142
	[Serializable]
	public class EventArgs : Object
	{
		// Token: 0x060009F6 RID: 2550 RVA: 0x00052FF8 File Offset: 0x000511F8
		// Note: this type is marked as 'beforefieldinit'.
		static EventArgs()
		{
			Il2CppClassPointerStore<EventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "EventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventArgs>.NativeClassPtr);
			EventArgs.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventArgs>.NativeClassPtr, "Empty");
			EventArgs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventArgs>.NativeClassPtr, 100665044);
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00053050 File Offset: 0x00051250
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventArgs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00004708 File Offset: 0x00002908
		public EventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x0005308C File Offset: 0x0005128C
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x00004711 File Offset: 0x00002911
		public unsafe static EventArgs Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventArgs.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventArgs>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventArgs.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
