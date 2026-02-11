using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace TMPro
{
	// Token: 0x02000004 RID: 4
	public class FastAction<A> : Object
	{
		// Token: 0x0600000F RID: 15 RVA: 0x0000A130 File Offset: 0x00008330
		// Note: this type is marked as 'beforefieldinit'.
		static FastAction()
		{
			Il2CppClassPointerStore<FastAction<A>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "FastAction`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<A>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastAction<A>>.NativeClassPtr);
			FastAction<A>.NativeFieldInfoPtr_delegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastAction<A>>.NativeClassPtr, "delegates");
			FastAction<A>.NativeFieldInfoPtr_lookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastAction<A>>.NativeClassPtr, "lookup");
			FastAction<A>.NativeMethodInfoPtr_Add_Public_Void_Action_1_A_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastAction<A>>.NativeClassPtr, 100663303);
			FastAction<A>.NativeMethodInfoPtr_Remove_Public_Void_Action_1_A_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastAction<A>>.NativeClassPtr, 100663304);
			FastAction<A>.NativeMethodInfoPtr_Call_Public_Void_A_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastAction<A>>.NativeClassPtr, 100663305);
			FastAction<A>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastAction<A>>.NativeClassPtr, 100663306);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000A214 File Offset: 0x00008414
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1032343, RefRangeEnd = 1032344, XrefRangeStart = 1032340, XrefRangeEnd = 1032343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Action<A> rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rhs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastAction<A>.NativeMethodInfoPtr_Add_Public_Void_Action_1_A_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000A258 File Offset: 0x00008458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1032347, RefRangeEnd = 1032348, XrefRangeStart = 1032344, XrefRangeEnd = 1032347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(Action<A> rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rhs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastAction<A>.NativeMethodInfoPtr_Remove_Public_Void_Action_1_A_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000A29C File Offset: 0x0000849C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1032349, RefRangeEnd = 1032350, XrefRangeStart = 1032348, XrefRangeEnd = 1032349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Call(A a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(A).IsValueType)
				{
					A a2 = a;
					intPtr = ((a2 is string) ? IL2CPP.ManagedStringToIl2Cpp(a2 as string) : IL2CPP.Il2CppObjectBaseToPtr(a2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref a;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FastAction<A>.NativeMethodInfoPtr_Call_Public_Void_A_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000A314 File Offset: 0x00008514
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1032370, RefRangeEnd = 1032373, XrefRangeStart = 1032350, XrefRangeEnd = 1032370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FastAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastAction<A>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastAction<A>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000020A0 File Offset: 0x000002A0
		public FastAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000015 RID: 21 RVA: 0x0000A350 File Offset: 0x00008550
		// (set) Token: 0x06000016 RID: 22 RVA: 0x000020A9 File Offset: 0x000002A9
		public unsafe LinkedList<Action<A>> delegates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastAction<A>.NativeFieldInfoPtr_delegates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<Action<A>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastAction<A>.NativeFieldInfoPtr_delegates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000017 RID: 23 RVA: 0x0000A380 File Offset: 0x00008580
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000020C8 File Offset: 0x000002C8
		public unsafe Dictionary<Action<A>, LinkedListNode<Action<A>>> lookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastAction<A>.NativeFieldInfoPtr_lookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Action<A>, LinkedListNode<Action<A>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastAction<A>.NativeFieldInfoPtr_lookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_delegates;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_lookup;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Action_1_A_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_Action_1_A_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_Call_Public_Void_A_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
