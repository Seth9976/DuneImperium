using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200025B RID: 603
	public class BasicNode<T> : LinkedPoolItem<BasicNode<T>>
	{
		// Token: 0x06002C6D RID: 11373 RVA: 0x000BF684 File Offset: 0x000BD884
		// Note: this type is marked as 'beforefieldinit'.
		static BasicNode()
		{
			Il2CppClassPointerStore<BasicNode<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "BasicNode`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicNode<T>>.NativeClassPtr);
			BasicNode<T>.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicNode<T>>.NativeClassPtr, "next");
			BasicNode<T>.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicNode<T>>.NativeClassPtr, "data");
			BasicNode<T>.NativeMethodInfoPtr_InsertFirst_Public_Void_byref_BasicNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicNode<T>>.NativeClassPtr, 100669861);
			BasicNode<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicNode<T>>.NativeClassPtr, 100669862);
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x000BF740 File Offset: 0x000BD940
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350332, RefRangeEnd = 350333, XrefRangeStart = 350330, XrefRangeEnd = 350332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertFirst(ref BasicNode<T> first)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(first);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BasicNode<T>.NativeMethodInfoPtr_InsertFirst_Public_Void_byref_BasicNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				first = ((intPtr4 == 0) ? null : new BasicNode<T>(intPtr4));
			}
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x000BF798 File Offset: 0x000BD998
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350334, RefRangeEnd = 350335, XrefRangeStart = 350333, XrefRangeEnd = 350334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicNode<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicNode<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x000120CF File Offset: 0x000102CF
		public BasicNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06002C71 RID: 11377 RVA: 0x000BF7D4 File Offset: 0x000BD9D4
		// (set) Token: 0x06002C72 RID: 11378 RVA: 0x000120D8 File Offset: 0x000102D8
		public unsafe BasicNode<T> next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicNode<T>.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicNode<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicNode<T>.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06002C73 RID: 11379 RVA: 0x000BF804 File Offset: 0x000BDA04
		// (set) Token: 0x06002C74 RID: 11380 RVA: 0x000BF82C File Offset: 0x000BDA2C
		public unsafe T data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicNode<T>.NativeFieldInfoPtr_data);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicNode<T>.NativeFieldInfoPtr_data);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x04001FDB RID: 8155
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x04001FDC RID: 8156
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04001FDD RID: 8157
		private static readonly IntPtr NativeMethodInfoPtr_InsertFirst_Public_Void_byref_BasicNode_1_T_0;

		// Token: 0x04001FDE RID: 8158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
