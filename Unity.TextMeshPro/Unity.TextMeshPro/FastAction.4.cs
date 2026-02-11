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
	// Token: 0x02000006 RID: 6
	public class FastAction<A, B, C> : Object
	{
		// Token: 0x06000023 RID: 35 RVA: 0x0000A68C File Offset: 0x0000888C
		// Note: this type is marked as 'beforefieldinit'.
		static FastAction()
		{
			Il2CppClassPointerStore<FastAction<A, B, C>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "FastAction`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<A>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<B>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<C>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastAction<A, B, C>>.NativeClassPtr);
			FastAction<A, B, C>.NativeFieldInfoPtr_delegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastAction<A, B, C>>.NativeClassPtr, "delegates");
			FastAction<A, B, C>.NativeFieldInfoPtr_lookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastAction<A, B, C>>.NativeClassPtr, "lookup");
			FastAction<A, B, C>.NativeMethodInfoPtr_Add_Public_Void_Action_3_A_B_C_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastAction<A, B, C>>.NativeClassPtr, 100663311);
			FastAction<A, B, C>.NativeMethodInfoPtr_Remove_Public_Void_Action_3_A_B_C_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastAction<A, B, C>>.NativeClassPtr, 100663312);
			FastAction<A, B, C>.NativeMethodInfoPtr_Call_Public_Void_A_B_C_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastAction<A, B, C>>.NativeClassPtr, 100663313);
			FastAction<A, B, C>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastAction<A, B, C>>.NativeClassPtr, 100663314);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000A794 File Offset: 0x00008994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1032343, RefRangeEnd = 1032344, XrefRangeStart = 1032343, XrefRangeEnd = 1032344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Action<A, B, C> rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rhs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastAction<A, B, C>.NativeMethodInfoPtr_Add_Public_Void_Action_3_A_B_C_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000A7D8 File Offset: 0x000089D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1032347, RefRangeEnd = 1032348, XrefRangeStart = 1032347, XrefRangeEnd = 1032348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(Action<A, B, C> rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rhs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastAction<A, B, C>.NativeMethodInfoPtr_Remove_Public_Void_Action_3_A_B_C_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000A81C File Offset: 0x00008A1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1032408, RefRangeEnd = 1032409, XrefRangeStart = 1032407, XrefRangeEnd = 1032408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Call(A a, B b, C c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
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
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(B).IsValueType)
			{
				B b2 = b;
				intPtr2 = ((b2 is string) ? IL2CPP.ManagedStringToIl2Cpp(b2 as string) : IL2CPP.Il2CppObjectBaseToPtr(b2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref b;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(C).IsValueType)
			{
				C c2 = c;
				intPtr3 = ((c2 is string) ? IL2CPP.ManagedStringToIl2Cpp(c2 as string) : IL2CPP.Il2CppObjectBaseToPtr(c2 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref c;
			}
			ptr4 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(FastAction<A, B, C>.NativeMethodInfoPtr_Call_Public_Void_A_B_C_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000A924 File Offset: 0x00008B24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1032418, RefRangeEnd = 1032419, XrefRangeStart = 1032409, XrefRangeEnd = 1032418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FastAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastAction<A, B, C>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastAction<A, B, C>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000212E File Offset: 0x0000032E
		public FastAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000029 RID: 41 RVA: 0x0000A960 File Offset: 0x00008B60
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002137 File Offset: 0x00000337
		public unsafe LinkedList<Action<A, B, C>> delegates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastAction<A, B, C>.NativeFieldInfoPtr_delegates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<Action<A, B, C>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastAction<A, B, C>.NativeFieldInfoPtr_delegates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002B RID: 43 RVA: 0x0000A990 File Offset: 0x00008B90
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002156 File Offset: 0x00000356
		public unsafe Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> lookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastAction<A, B, C>.NativeFieldInfoPtr_lookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastAction<A, B, C>.NativeFieldInfoPtr_lookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_delegates;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_lookup;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Action_3_A_B_C_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_Action_3_A_B_C_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_Call_Public_Void_A_B_C_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
