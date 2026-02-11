using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Steamworks
{
	// Token: 0x020000C3 RID: 195
	public static class Helpers : Object
	{
		// Token: 0x06000C91 RID: 3217 RVA: 0x00053280 File Offset: 0x00051480
		// Note: this type is marked as 'beforefieldinit'.
		static Helpers()
		{
			Il2CppClassPointerStore<Helpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "Helpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Helpers>.NativeClassPtr);
			Helpers.NativeFieldInfoPtr_MemoryBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helpers>.NativeClassPtr, "MemoryBufferSize");
			Helpers.NativeFieldInfoPtr_BufferPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helpers>.NativeClassPtr, "BufferPool");
			Helpers.NativeFieldInfoPtr_BufferPoolIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helpers>.NativeClassPtr, "BufferPoolIndex");
			Helpers.NativeMethodInfoPtr_TakeMemory_Public_Static_Memory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helpers>.NativeClassPtr, 100666387);
			Helpers.NativeMethodInfoPtr_TakeBuffer_Public_Static_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helpers>.NativeClassPtr, 100666388);
			Helpers.NativeMethodInfoPtr_MemoryToString_Internal_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helpers>.NativeClassPtr, 100666389);
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00053328 File Offset: 0x00051528
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 947539, RefRangeEnd = 947577, XrefRangeStart = 947528, XrefRangeEnd = 947539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Helpers.Memory TakeMemory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Helpers.NativeMethodInfoPtr_TakeMemory_Public_Static_Memory_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00053358 File Offset: 0x00051558
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 947611, RefRangeEnd = 947619, XrefRangeStart = 947577, XrefRangeEnd = 947611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> TakeBuffer(int minSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Helpers.NativeMethodInfoPtr_TakeBuffer_Public_Static_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00053398 File Offset: 0x00051598
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 947625, RefRangeEnd = 947664, XrefRangeStart = 947619, XrefRangeEnd = 947625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MemoryToString(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Helpers.NativeMethodInfoPtr_MemoryToString_Internal_Static_String_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x000031D5 File Offset: 0x000013D5
		public Helpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x000533D0 File Offset: 0x000515D0
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x000031DE File Offset: 0x000013DE
		public unsafe static int MemoryBufferSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Helpers.NativeFieldInfoPtr_MemoryBufferSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Helpers.NativeFieldInfoPtr_MemoryBufferSize, (void*)(&value));
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x000533EC File Offset: 0x000515EC
		// (set) Token: 0x06000C99 RID: 3225 RVA: 0x000031EC File Offset: 0x000013EC
		public unsafe static Il2CppReferenceArray<Il2CppStructArray<byte>> BufferPool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Helpers.NativeFieldInfoPtr_BufferPool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<byte>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Helpers.NativeFieldInfoPtr_BufferPool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x00053414 File Offset: 0x00051614
		// (set) Token: 0x06000C9B RID: 3227 RVA: 0x000031FE File Offset: 0x000013FE
		public unsafe static int BufferPoolIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Helpers.NativeFieldInfoPtr_BufferPoolIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Helpers.NativeFieldInfoPtr_BufferPoolIndex, (void*)(&value));
			}
		}

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeFieldInfoPtr_MemoryBufferSize;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeFieldInfoPtr_BufferPool;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeFieldInfoPtr_BufferPoolIndex;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeMethodInfoPtr_TakeMemory_Public_Static_Memory_0;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeMethodInfoPtr_TakeBuffer_Public_Static_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeMethodInfoPtr_MemoryToString_Internal_Static_String_IntPtr_0;

		// Token: 0x02000283 RID: 643
		[StructLayout(2)]
		public struct Memory
		{
			// Token: 0x06002097 RID: 8343 RVA: 0x0008F4D4 File Offset: 0x0008D6D4
			// Note: this type is marked as 'beforefieldinit'.
			static Memory()
			{
				Il2CppClassPointerStore<Helpers.Memory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Helpers>.NativeClassPtr, "Memory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Helpers.Memory>.NativeClassPtr);
				Helpers.Memory.NativeFieldInfoPtr_MaxBagSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helpers.Memory>.NativeClassPtr, "MaxBagSize");
				Helpers.Memory.NativeFieldInfoPtr_BufferBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helpers.Memory>.NativeClassPtr, "BufferBag");
				Helpers.Memory.NativeFieldInfoPtr__Ptr_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helpers.Memory>.NativeClassPtr, "<Ptr>k__BackingField");
				Helpers.Memory.NativeMethodInfoPtr_get_Ptr_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helpers.Memory>.NativeClassPtr, 100666391);
				Helpers.Memory.NativeMethodInfoPtr_set_Ptr_Private_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helpers.Memory>.NativeClassPtr, 100666392);
				Helpers.Memory.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_byref_Memory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helpers.Memory>.NativeClassPtr, 100666393);
				Helpers.Memory.NativeMethodInfoPtr_Take_Internal_Static_Memory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helpers.Memory>.NativeClassPtr, 100666394);
				Helpers.Memory.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helpers.Memory>.NativeClassPtr, 100666395);
			}

			// Token: 0x17000868 RID: 2152
			// (get) Token: 0x06002098 RID: 8344 RVA: 0x0008F5A0 File Offset: 0x0008D7A0
			// (set) Token: 0x06002099 RID: 8345 RVA: 0x0008F5D0 File Offset: 0x0008D7D0
			public unsafe IntPtr Ptr
			{
				[CallerCount(99)]
				[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Helpers.Memory.NativeMethodInfoPtr_get_Ptr_Public_get_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(44)]
				[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Helpers.Memory.NativeMethodInfoPtr_set_Ptr_Private_set_Void_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600209A RID: 8346 RVA: 0x0008F604 File Offset: 0x0008D804
			[CallerCount(76)]
			[CachedScanResults(RefRangeStart = 947318, RefRangeEnd = 947394, XrefRangeStart = 947315, XrefRangeEnd = 947318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static implicit operator IntPtr([In] ref Helpers.Memory m)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &m;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Helpers.Memory.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_byref_Memory_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600209B RID: 8347 RVA: 0x0008F644 File Offset: 0x0008D844
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 947419, RefRangeEnd = 947420, XrefRangeStart = 947394, XrefRangeEnd = 947419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Helpers.Memory Take()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Helpers.Memory.NativeMethodInfoPtr_Take_Internal_Static_Memory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600209C RID: 8348 RVA: 0x0008F674 File Offset: 0x0008D874
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 947449, RefRangeEnd = 947528, XrefRangeStart = 947420, XrefRangeEnd = 947449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Helpers.Memory.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600209D RID: 8349 RVA: 0x0000C7FA File Offset: 0x0000A9FA
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Helpers.Memory>.NativeClassPtr, ref this));
			}

			// Token: 0x17000866 RID: 2150
			// (get) Token: 0x0600209E RID: 8350 RVA: 0x0008F69C File Offset: 0x0008D89C
			// (set) Token: 0x0600209F RID: 8351 RVA: 0x0000C80C File Offset: 0x0000AA0C
			public unsafe static int MaxBagSize
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Helpers.Memory.NativeFieldInfoPtr_MaxBagSize, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Helpers.Memory.NativeFieldInfoPtr_MaxBagSize, (void*)(&value));
				}
			}

			// Token: 0x17000867 RID: 2151
			// (get) Token: 0x060020A0 RID: 8352 RVA: 0x0008F6B8 File Offset: 0x0008D8B8
			// (set) Token: 0x060020A1 RID: 8353 RVA: 0x0000C81A File Offset: 0x0000AA1A
			public unsafe static Queue<IntPtr> BufferBag
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Helpers.Memory.NativeFieldInfoPtr_BufferBag, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<IntPtr>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Helpers.Memory.NativeFieldInfoPtr_BufferBag, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040022DC RID: 8924
			private static readonly IntPtr NativeFieldInfoPtr_MaxBagSize;

			// Token: 0x040022DD RID: 8925
			private static readonly IntPtr NativeFieldInfoPtr_BufferBag;

			// Token: 0x040022DE RID: 8926
			private static readonly IntPtr NativeFieldInfoPtr__Ptr_k__BackingField;

			// Token: 0x040022DF RID: 8927
			private static readonly IntPtr NativeMethodInfoPtr_get_Ptr_Public_get_IntPtr_0;

			// Token: 0x040022E0 RID: 8928
			private static readonly IntPtr NativeMethodInfoPtr_set_Ptr_Private_set_Void_IntPtr_0;

			// Token: 0x040022E1 RID: 8929
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_byref_Memory_0;

			// Token: 0x040022E2 RID: 8930
			private static readonly IntPtr NativeMethodInfoPtr_Take_Internal_Static_Memory_0;

			// Token: 0x040022E3 RID: 8931
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040022E4 RID: 8932
			[FieldOffset(0)]
			public IntPtr _Ptr_k__BackingField;
		}
	}
}
