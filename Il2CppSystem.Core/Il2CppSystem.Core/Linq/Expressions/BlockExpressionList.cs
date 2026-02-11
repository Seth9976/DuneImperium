using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000038 RID: 56
	public class BlockExpressionList : Object
	{
		// Token: 0x06000347 RID: 839 RVA: 0x000205B8 File Offset: 0x0001E7B8
		// Note: this type is marked as 'beforefieldinit'.
		static BlockExpressionList()
		{
			Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "BlockExpressionList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr);
			BlockExpressionList.NativeFieldInfoPtr__block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr, "_block");
			BlockExpressionList.NativeFieldInfoPtr__arg0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr, "_arg0");
			BlockExpressionList.NativeMethodInfoPtr__ctor_Internal_Void_BlockExpression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr, 100664117);
			BlockExpressionList.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr, 100664118);
			BlockExpressionList.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr, 100664119);
			BlockExpressionList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr, 100664120);
			BlockExpressionList.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr, 100664121);
			BlockExpressionList.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr, 100664122);
			BlockExpressionList.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr, 100664123);
			BlockExpressionList.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr, 100664124);
			BlockExpressionList.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr, 100664125);
			BlockExpressionList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr, 100664126);
			BlockExpressionList.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr, 100664127);
			BlockExpressionList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr, 100664128);
			BlockExpressionList.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr, 100664129);
			BlockExpressionList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr, 100664130);
			BlockExpressionList.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr, 100664131);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0002073C File Offset: 0x0001E93C
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlockExpressionList(BlockExpression provider, Expression arg0)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList.NativeMethodInfoPtr__ctor_Internal_Void_BlockExpression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0002079C File Offset: 0x0001E99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012030, XrefRangeEnd = 1012031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int IndexOf(Expression item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000207EC File Offset: 0x0001E9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012031, XrefRangeEnd = 1012034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Insert(int index, Expression item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0002083C File Offset: 0x0001EA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012034, XrefRangeEnd = 1012037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000095 RID: 149
		public unsafe virtual Expression this[int index]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012037, XrefRangeEnd = 1012040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00020918 File Offset: 0x0001EB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012040, XrefRangeEnd = 1012043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(Expression item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0002095C File Offset: 0x0001EB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012043, XrefRangeEnd = 1012046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00020990 File Offset: 0x0001EB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012046, XrefRangeEnd = 1012048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(Expression item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000209E0 File Offset: 0x0001EBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012048, XrefRangeEnd = 1012055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppReferenceArray<Expression> array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00020A30 File Offset: 0x0001EC30
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000353 RID: 851 RVA: 0x00020A6C File Offset: 0x0001EC6C
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012055, XrefRangeEnd = 1012058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00020AA8 File Offset: 0x0001ECA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012058, XrefRangeEnd = 1012061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(Expression item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00020AF8 File Offset: 0x0001ECF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012061, XrefRangeEnd = 1012066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<Expression> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Expression>>(intPtr3) : null;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00020B38 File Offset: 0x0001ED38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00002BB8 File Offset: 0x00000DB8
		public BlockExpressionList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00020B78 File Offset: 0x0001ED78
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00002BC1 File Offset: 0x00000DC1
		public unsafe BlockExpression _block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockExpressionList.NativeFieldInfoPtr__block);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlockExpression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockExpressionList.NativeFieldInfoPtr__block), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00020BA8 File Offset: 0x0001EDA8
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00002BE0 File Offset: 0x00000DE0
		public unsafe Expression _arg0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockExpressionList.NativeFieldInfoPtr__arg0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockExpressionList.NativeFieldInfoPtr__arg0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeFieldInfoPtr__block;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr__arg0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BlockExpression_Expression_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_Expression_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_Expression_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Expression_Int32_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_Expression_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Expression_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Expression_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Expression_Int32_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Expression_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Expression_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x020001DB RID: 475
		[ObfuscatedName("System.Linq.Expressions.BlockExpressionList+<GetEnumerator>d__18")]
		public sealed class _GetEnumerator_d__18 : Object
		{
			// Token: 0x0600164A RID: 5706 RVA: 0x0006D6C0 File Offset: 0x0006B8C0
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__18()
			{
				Il2CppClassPointerStore<BlockExpressionList._GetEnumerator_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlockExpressionList>.NativeClassPtr, "<GetEnumerator>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockExpressionList._GetEnumerator_d__18>.NativeClassPtr);
				BlockExpressionList._GetEnumerator_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockExpressionList._GetEnumerator_d__18>.NativeClassPtr, "<>1__state");
				BlockExpressionList._GetEnumerator_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockExpressionList._GetEnumerator_d__18>.NativeClassPtr, "<>2__current");
				BlockExpressionList._GetEnumerator_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockExpressionList._GetEnumerator_d__18>.NativeClassPtr, "<>4__this");
				BlockExpressionList._GetEnumerator_d__18.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockExpressionList._GetEnumerator_d__18>.NativeClassPtr, "<i>5__2");
				BlockExpressionList._GetEnumerator_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList._GetEnumerator_d__18>.NativeClassPtr, 100664132);
				BlockExpressionList._GetEnumerator_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList._GetEnumerator_d__18>.NativeClassPtr, 100664133);
				BlockExpressionList._GetEnumerator_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList._GetEnumerator_d__18>.NativeClassPtr, 100664134);
				BlockExpressionList._GetEnumerator_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Linq_Expressions_Expression__get_Current_Private_Virtual_Final_New_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList._GetEnumerator_d__18>.NativeClassPtr, 100664135);
				BlockExpressionList._GetEnumerator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList._GetEnumerator_d__18>.NativeClassPtr, 100664136);
				BlockExpressionList._GetEnumerator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockExpressionList._GetEnumerator_d__18>.NativeClassPtr, 100664137);
			}

			// Token: 0x0600164B RID: 5707 RVA: 0x0006D7B4 File Offset: 0x0006B9B4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlockExpressionList._GetEnumerator_d__18>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList._GetEnumerator_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600164C RID: 5708 RVA: 0x0006D7FC File Offset: 0x0006B9FC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList._GetEnumerator_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600164D RID: 5709 RVA: 0x0006D830 File Offset: 0x0006BA30
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList._GetEnumerator_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006A4 RID: 1700
			// (get) Token: 0x0600164E RID: 5710 RVA: 0x0006D86C File Offset: 0x0006BA6C
			public unsafe Expression System.Collections.Generic.IEnumerator<System.Linq.Expressions.Expression>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList._GetEnumerator_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Linq_Expressions_Expression__get_Current_Private_Virtual_Final_New_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
				}
			}

			// Token: 0x0600164F RID: 5711 RVA: 0x0006D8AC File Offset: 0x0006BAAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012025, XrefRangeEnd = 1012030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList._GetEnumerator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006A5 RID: 1701
			// (get) Token: 0x06001650 RID: 5712 RVA: 0x0006D8E0 File Offset: 0x0006BAE0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockExpressionList._GetEnumerator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001651 RID: 5713 RVA: 0x000097B5 File Offset: 0x000079B5
			public _GetEnumerator_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A0 RID: 1696
			// (get) Token: 0x06001652 RID: 5714 RVA: 0x0006D920 File Offset: 0x0006BB20
			// (set) Token: 0x06001653 RID: 5715 RVA: 0x000097BE File Offset: 0x000079BE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockExpressionList._GetEnumerator_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockExpressionList._GetEnumerator_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006A1 RID: 1697
			// (get) Token: 0x06001654 RID: 5716 RVA: 0x0006D948 File Offset: 0x0006BB48
			// (set) Token: 0x06001655 RID: 5717 RVA: 0x000097D9 File Offset: 0x000079D9
			public unsafe Expression __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockExpressionList._GetEnumerator_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockExpressionList._GetEnumerator_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006A2 RID: 1698
			// (get) Token: 0x06001656 RID: 5718 RVA: 0x0006D978 File Offset: 0x0006BB78
			// (set) Token: 0x06001657 RID: 5719 RVA: 0x000097F8 File Offset: 0x000079F8
			public unsafe BlockExpressionList __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockExpressionList._GetEnumerator_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlockExpressionList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockExpressionList._GetEnumerator_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006A3 RID: 1699
			// (get) Token: 0x06001658 RID: 5720 RVA: 0x0006D9A8 File Offset: 0x0006BBA8
			// (set) Token: 0x06001659 RID: 5721 RVA: 0x00009817 File Offset: 0x00007A17
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockExpressionList._GetEnumerator_d__18.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockExpressionList._GetEnumerator_d__18.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04000FAF RID: 4015
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000FB0 RID: 4016
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000FB1 RID: 4017
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000FB2 RID: 4018
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04000FB3 RID: 4019
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000FB4 RID: 4020
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FB5 RID: 4021
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000FB6 RID: 4022
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Linq_Expressions_Expression__get_Current_Private_Virtual_Final_New_get_Expression_0;

			// Token: 0x04000FB7 RID: 4023
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FB8 RID: 4024
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
