using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace UnityEngine.Rendering
{
	// Token: 0x020000BF RID: 191
	public class AtlasAllocator : Object
	{
		// Token: 0x06000D92 RID: 3474 RVA: 0x0003F0A0 File Offset: 0x0003D2A0
		// Note: this type is marked as 'beforefieldinit'.
		static AtlasAllocator()
		{
			Il2CppClassPointerStore<AtlasAllocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "AtlasAllocator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AtlasAllocator>.NativeClassPtr);
			AtlasAllocator.NativeFieldInfoPtr_m_Root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocator>.NativeClassPtr, "m_Root");
			AtlasAllocator.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocator>.NativeClassPtr, "m_Width");
			AtlasAllocator.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocator>.NativeClassPtr, "m_Height");
			AtlasAllocator.NativeFieldInfoPtr_powerOfTwoPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocator>.NativeClassPtr, "powerOfTwoPadding");
			AtlasAllocator.NativeFieldInfoPtr_m_NodePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocator>.NativeClassPtr, "m_NodePool");
			AtlasAllocator.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocator>.NativeClassPtr, 100665254);
			AtlasAllocator.NativeMethodInfoPtr_Allocate_Public_Boolean_byref_Vector4_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocator>.NativeClassPtr, 100665255);
			AtlasAllocator.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocator>.NativeClassPtr, 100665256);
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0003F170 File Offset: 0x0003D370
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 973027, RefRangeEnd = 973028, XrefRangeStart = 972985, XrefRangeEnd = 973027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AtlasAllocator(int width, int height, bool potPadding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AtlasAllocator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref potPadding;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocator.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0003F1D4 File Offset: 0x0003D3D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 973031, RefRangeEnd = 973033, XrefRangeStart = 973028, XrefRangeEnd = 973031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Allocate(ref Vector4 result, int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &result;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocator.NativeMethodInfoPtr_Allocate_Public_Boolean_byref_Vector4_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0003F23C File Offset: 0x0003D43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973033, XrefRangeEnd = 973034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocator.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00007E98 File Offset: 0x00006098
		public AtlasAllocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x0003F270 File Offset: 0x0003D470
		// (set) Token: 0x06000D98 RID: 3480 RVA: 0x00007EA1 File Offset: 0x000060A1
		public unsafe AtlasAllocator.AtlasNode m_Root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocator.NativeFieldInfoPtr_m_Root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AtlasAllocator.AtlasNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocator.NativeFieldInfoPtr_m_Root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x0003F2A0 File Offset: 0x0003D4A0
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x00007EC0 File Offset: 0x000060C0
		public unsafe int m_Width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocator.NativeFieldInfoPtr_m_Width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocator.NativeFieldInfoPtr_m_Width)) = value;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x0003F2C8 File Offset: 0x0003D4C8
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x00007EDB File Offset: 0x000060DB
		public unsafe int m_Height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocator.NativeFieldInfoPtr_m_Height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocator.NativeFieldInfoPtr_m_Height)) = value;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0003F2F0 File Offset: 0x0003D4F0
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x00007EF6 File Offset: 0x000060F6
		public unsafe bool powerOfTwoPadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocator.NativeFieldInfoPtr_powerOfTwoPadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocator.NativeFieldInfoPtr_powerOfTwoPadding)) = value;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x0003F318 File Offset: 0x0003D518
		// (set) Token: 0x06000DA0 RID: 3488 RVA: 0x00007F11 File Offset: 0x00006111
		public unsafe ObjectPool<AtlasAllocator.AtlasNode> m_NodePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocator.NativeFieldInfoPtr_m_NodePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<AtlasAllocator.AtlasNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocator.NativeFieldInfoPtr_m_NodePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeFieldInfoPtr_m_Root;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeFieldInfoPtr_powerOfTwoPadding;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeFieldInfoPtr_m_NodePool;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_Allocate_Public_Boolean_byref_Vector4_Int32_Int32_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x020001EB RID: 491
		public class AtlasNode : Object
		{
			// Token: 0x06001A35 RID: 6709 RVA: 0x0006C800 File Offset: 0x0006AA00
			// Note: this type is marked as 'beforefieldinit'.
			static AtlasNode()
			{
				Il2CppClassPointerStore<AtlasAllocator.AtlasNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AtlasAllocator>.NativeClassPtr, "AtlasNode");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AtlasAllocator.AtlasNode>.NativeClassPtr);
				AtlasAllocator.AtlasNode.NativeFieldInfoPtr_m_RightChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocator.AtlasNode>.NativeClassPtr, "m_RightChild");
				AtlasAllocator.AtlasNode.NativeFieldInfoPtr_m_BottomChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocator.AtlasNode>.NativeClassPtr, "m_BottomChild");
				AtlasAllocator.AtlasNode.NativeFieldInfoPtr_m_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocator.AtlasNode>.NativeClassPtr, "m_Rect");
				AtlasAllocator.AtlasNode.NativeMethodInfoPtr_Allocate_Public_AtlasNode_byref_ObjectPool_1_AtlasNode_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocator.AtlasNode>.NativeClassPtr, 100665257);
				AtlasAllocator.AtlasNode.NativeMethodInfoPtr_Release_Public_Void_byref_ObjectPool_1_AtlasNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocator.AtlasNode>.NativeClassPtr, 100665258);
				AtlasAllocator.AtlasNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocator.AtlasNode>.NativeClassPtr, 100665259);
			}

			// Token: 0x06001A36 RID: 6710 RVA: 0x0006C8A4 File Offset: 0x0006AAA4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 972967, RefRangeEnd = 972968, XrefRangeStart = 972959, XrefRangeEnd = 972967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AtlasAllocator.AtlasNode Allocate(ref ObjectPool<AtlasAllocator.AtlasNode> pool, int width, int height, bool powerOfTwoPadding)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(pool);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref powerOfTwoPadding;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AtlasAllocator.AtlasNode.NativeMethodInfoPtr_Allocate_Public_AtlasNode_byref_ObjectPool_1_AtlasNode_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pool = ((intPtr4 == 0) ? null : new ObjectPool<AtlasAllocator.AtlasNode>(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<AtlasAllocator.AtlasNode>(intPtr5) : null;
			}

			// Token: 0x06001A37 RID: 6711 RVA: 0x0006C938 File Offset: 0x0006AB38
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 972979, RefRangeEnd = 972984, XrefRangeStart = 972968, XrefRangeEnd = 972979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Release(ref ObjectPool<AtlasAllocator.AtlasNode> pool)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(pool);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AtlasAllocator.AtlasNode.NativeMethodInfoPtr_Release_Public_Void_byref_ObjectPool_1_AtlasNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					pool = ((intPtr4 == 0) ? null : new ObjectPool<AtlasAllocator.AtlasNode>(intPtr4));
				}
			}

			// Token: 0x06001A38 RID: 6712 RVA: 0x0006C990 File Offset: 0x0006AB90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972984, XrefRangeEnd = 972985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AtlasNode()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AtlasAllocator.AtlasNode>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocator.AtlasNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A39 RID: 6713 RVA: 0x0000D31E File Offset: 0x0000B51E
			public AtlasNode(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700075E RID: 1886
			// (get) Token: 0x06001A3A RID: 6714 RVA: 0x0006C9CC File Offset: 0x0006ABCC
			// (set) Token: 0x06001A3B RID: 6715 RVA: 0x0000D327 File Offset: 0x0000B527
			public unsafe AtlasAllocator.AtlasNode m_RightChild
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocator.AtlasNode.NativeFieldInfoPtr_m_RightChild);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AtlasAllocator.AtlasNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocator.AtlasNode.NativeFieldInfoPtr_m_RightChild), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700075F RID: 1887
			// (get) Token: 0x06001A3C RID: 6716 RVA: 0x0006C9FC File Offset: 0x0006ABFC
			// (set) Token: 0x06001A3D RID: 6717 RVA: 0x0000D346 File Offset: 0x0000B546
			public unsafe AtlasAllocator.AtlasNode m_BottomChild
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocator.AtlasNode.NativeFieldInfoPtr_m_BottomChild);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AtlasAllocator.AtlasNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocator.AtlasNode.NativeFieldInfoPtr_m_BottomChild), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000760 RID: 1888
			// (get) Token: 0x06001A3E RID: 6718 RVA: 0x0006CA2C File Offset: 0x0006AC2C
			// (set) Token: 0x06001A3F RID: 6719 RVA: 0x0000D365 File Offset: 0x0000B565
			public unsafe Vector4 m_Rect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocator.AtlasNode.NativeFieldInfoPtr_m_Rect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocator.AtlasNode.NativeFieldInfoPtr_m_Rect)) = value;
				}
			}

			// Token: 0x04001315 RID: 4885
			private static readonly IntPtr NativeFieldInfoPtr_m_RightChild;

			// Token: 0x04001316 RID: 4886
			private static readonly IntPtr NativeFieldInfoPtr_m_BottomChild;

			// Token: 0x04001317 RID: 4887
			private static readonly IntPtr NativeFieldInfoPtr_m_Rect;

			// Token: 0x04001318 RID: 4888
			private static readonly IntPtr NativeMethodInfoPtr_Allocate_Public_AtlasNode_byref_ObjectPool_1_AtlasNode_Int32_Int32_Boolean_0;

			// Token: 0x04001319 RID: 4889
			private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_byref_ObjectPool_1_AtlasNode_0;

			// Token: 0x0400131A RID: 4890
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001EC RID: 492
		[ObfuscatedName("UnityEngine.Rendering.AtlasAllocator+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001A40 RID: 6720 RVA: 0x0006CA54 File Offset: 0x0006AC54
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AtlasAllocator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AtlasAllocator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AtlasAllocator.__c>.NativeClassPtr);
				AtlasAllocator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocator.__c>.NativeClassPtr, "<>9");
				AtlasAllocator.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocator.__c>.NativeClassPtr, "<>9__6_0");
				AtlasAllocator.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocator.__c>.NativeClassPtr, "<>9__6_1");
				AtlasAllocator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocator.__c>.NativeClassPtr, 100665261);
				AtlasAllocator.__c.NativeMethodInfoPtr___ctor_b__6_0_Internal_Void_AtlasNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocator.__c>.NativeClassPtr, 100665262);
				AtlasAllocator.__c.NativeMethodInfoPtr___ctor_b__6_1_Internal_Void_AtlasNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocator.__c>.NativeClassPtr, 100665263);
			}

			// Token: 0x06001A41 RID: 6721 RVA: 0x0006CAF8 File Offset: 0x0006ACF8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AtlasAllocator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A42 RID: 6722 RVA: 0x0006CB34 File Offset: 0x0006AD34
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__6_0(AtlasAllocator.AtlasNode _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocator.__c.NativeMethodInfoPtr___ctor_b__6_0_Internal_Void_AtlasNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A43 RID: 6723 RVA: 0x0006CB78 File Offset: 0x0006AD78
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__6_1(AtlasAllocator.AtlasNode _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocator.__c.NativeMethodInfoPtr___ctor_b__6_1_Internal_Void_AtlasNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A44 RID: 6724 RVA: 0x0000D380 File Offset: 0x0000B580
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000761 RID: 1889
			// (get) Token: 0x06001A45 RID: 6725 RVA: 0x0006CBBC File Offset: 0x0006ADBC
			// (set) Token: 0x06001A46 RID: 6726 RVA: 0x0000D389 File Offset: 0x0000B589
			public unsafe static AtlasAllocator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AtlasAllocator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AtlasAllocator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AtlasAllocator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000762 RID: 1890
			// (get) Token: 0x06001A47 RID: 6727 RVA: 0x0006CBE4 File Offset: 0x0006ADE4
			// (set) Token: 0x06001A48 RID: 6728 RVA: 0x0000D39B File Offset: 0x0000B59B
			public unsafe static UnityAction<AtlasAllocator.AtlasNode> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AtlasAllocator.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<AtlasAllocator.AtlasNode>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AtlasAllocator.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000763 RID: 1891
			// (get) Token: 0x06001A49 RID: 6729 RVA: 0x0006CC0C File Offset: 0x0006AE0C
			// (set) Token: 0x06001A4A RID: 6730 RVA: 0x0000D3AD File Offset: 0x0000B5AD
			public unsafe static UnityAction<AtlasAllocator.AtlasNode> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AtlasAllocator.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<AtlasAllocator.AtlasNode>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AtlasAllocator.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400131B RID: 4891
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400131C RID: 4892
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400131D RID: 4893
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x0400131E RID: 4894
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400131F RID: 4895
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__6_0_Internal_Void_AtlasNode_0;

			// Token: 0x04001320 RID: 4896
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__6_1_Internal_Void_AtlasNode_0;
		}
	}
}
