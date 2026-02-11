using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000EC RID: 236
	public sealed class EventHandlerList : Object
	{
		// Token: 0x06000F7C RID: 3964 RVA: 0x000565AC File Offset: 0x000547AC
		// Note: this type is marked as 'beforefieldinit'.
		static EventHandlerList()
		{
			Il2CppClassPointerStore<EventHandlerList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "EventHandlerList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventHandlerList>.NativeClassPtr);
			EventHandlerList.NativeFieldInfoPtr__head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventHandlerList>.NativeClassPtr, "_head");
			EventHandlerList.NativeFieldInfoPtr__parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventHandlerList>.NativeClassPtr, "_parent");
			EventHandlerList.NativeMethodInfoPtr_get_Item_Public_get_Delegate_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandlerList>.NativeClassPtr, 100665533);
			EventHandlerList.NativeMethodInfoPtr_Find_Private_ListEntry_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandlerList>.NativeClassPtr, 100665534);
		}

		// Token: 0x170004BD RID: 1213
		public unsafe Delegate this[Object key]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 456360, RefRangeEnd = 456362, XrefRangeStart = 456359, XrefRangeEnd = 456360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandlerList.NativeMethodInfoPtr_get_Item_Public_get_Delegate_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0005667C File Offset: 0x0005487C
		[CallerCount(0)]
		public unsafe EventHandlerList.ListEntry Find(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandlerList.NativeMethodInfoPtr_Find_Private_ListEntry_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventHandlerList.ListEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00007987 File Offset: 0x00005B87
		public EventHandlerList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x000566CC File Offset: 0x000548CC
		// (set) Token: 0x06000F81 RID: 3969 RVA: 0x00007990 File Offset: 0x00005B90
		public unsafe EventHandlerList.ListEntry _head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.NativeFieldInfoPtr__head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandlerList.ListEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.NativeFieldInfoPtr__head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x000566FC File Offset: 0x000548FC
		// (set) Token: 0x06000F83 RID: 3971 RVA: 0x000079AF File Offset: 0x00005BAF
		public unsafe Component _parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.NativeFieldInfoPtr__parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.NativeFieldInfoPtr__parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeFieldInfoPtr__head;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeFieldInfoPtr__parent;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Delegate_Object_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_Find_Private_ListEntry_Object_0;

		// Token: 0x020002D6 RID: 726
		public sealed class ListEntry : Object
		{
			// Token: 0x06002BF7 RID: 11255 RVA: 0x000C2168 File Offset: 0x000C0368
			// Note: this type is marked as 'beforefieldinit'.
			static ListEntry()
			{
				Il2CppClassPointerStore<EventHandlerList.ListEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventHandlerList>.NativeClassPtr, "ListEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventHandlerList.ListEntry>.NativeClassPtr);
				EventHandlerList.ListEntry.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventHandlerList.ListEntry>.NativeClassPtr, "_next");
				EventHandlerList.ListEntry.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventHandlerList.ListEntry>.NativeClassPtr, "_key");
				EventHandlerList.ListEntry.NativeFieldInfoPtr__handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventHandlerList.ListEntry>.NativeClassPtr, "_handler");
			}

			// Token: 0x06002BF8 RID: 11256 RVA: 0x00013CCF File Offset: 0x00011ECF
			public ListEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DCE RID: 3534
			// (get) Token: 0x06002BF9 RID: 11257 RVA: 0x000C21D0 File Offset: 0x000C03D0
			// (set) Token: 0x06002BFA RID: 11258 RVA: 0x00013CD8 File Offset: 0x00011ED8
			public unsafe EventHandlerList.ListEntry _next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.ListEntry.NativeFieldInfoPtr__next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandlerList.ListEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.ListEntry.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DCF RID: 3535
			// (get) Token: 0x06002BFB RID: 11259 RVA: 0x000C2200 File Offset: 0x000C0400
			// (set) Token: 0x06002BFC RID: 11260 RVA: 0x00013CF7 File Offset: 0x00011EF7
			public unsafe Object _key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.ListEntry.NativeFieldInfoPtr__key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.ListEntry.NativeFieldInfoPtr__key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DD0 RID: 3536
			// (get) Token: 0x06002BFD RID: 11261 RVA: 0x000C2230 File Offset: 0x000C0430
			// (set) Token: 0x06002BFE RID: 11262 RVA: 0x00013D16 File Offset: 0x00011F16
			public unsafe Delegate _handler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.ListEntry.NativeFieldInfoPtr__handler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.ListEntry.NativeFieldInfoPtr__handler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040022CC RID: 8908
			private static readonly IntPtr NativeFieldInfoPtr__next;

			// Token: 0x040022CD RID: 8909
			private static readonly IntPtr NativeFieldInfoPtr__key;

			// Token: 0x040022CE RID: 8910
			private static readonly IntPtr NativeFieldInfoPtr__handler;
		}
	}
}
