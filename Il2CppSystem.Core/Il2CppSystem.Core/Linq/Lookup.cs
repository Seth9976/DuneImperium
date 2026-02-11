using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq
{
	// Token: 0x0200001D RID: 29
	[DefaultMember("Item")]
	public class Lookup<TKey, TElement> : Object
	{
		// Token: 0x0600011C RID: 284 RVA: 0x000150E0 File Offset: 0x000132E0
		// Note: this type is marked as 'beforefieldinit'.
		static Lookup()
		{
			Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "Lookup`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr);
			Lookup<TKey, TElement>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, "comparer");
			Lookup<TKey, TElement>.NativeFieldInfoPtr_groupings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, "groupings");
			Lookup<TKey, TElement>.NativeFieldInfoPtr_lastGrouping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, "lastGrouping");
			Lookup<TKey, TElement>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, "count");
			Lookup<TKey, TElement>.NativeMethodInfoPtr_Create_Internal_Static_Lookup_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, 100663727);
			Lookup<TKey, TElement>.NativeMethodInfoPtr__ctor_Private_Void_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, 100663728);
			Lookup<TKey, TElement>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_IGrouping_2_TKey_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, 100663729);
			Lookup<TKey, TElement>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, 100663730);
			Lookup<TKey, TElement>.NativeMethodInfoPtr_InternalGetHashCode_Internal_Int32_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, 100663731);
			Lookup<TKey, TElement>.NativeMethodInfoPtr_GetGrouping_Internal_Grouping_TKey_TElement_TKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, 100663732);
			Lookup<TKey, TElement>.NativeMethodInfoPtr_Resize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, 100663733);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0001523C File Offset: 0x0001343C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1006306, RefRangeEnd = 1006308, XrefRangeStart = 1006281, XrefRangeEnd = 1006306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public static Lookup<TKey, TElement> Create<TSource>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			/*
An exception occurred when decompiling this method (0600011D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Il2CppSystem.Linq.Lookup`2<TKey,TElement> Il2CppSystem.Linq.Lookup`2::Create<TSource>(Il2CppSystem.Collections.Generic.IEnumerable`1<TSource>,Il2CppSystem.Func`2<TSource,TKey>,Il2CppSystem.Func`2<TSource,TElement>,Il2CppSystem.Collections.Generic.IEqualityComparer`1<TKey>)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 874
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000152B8 File Offset: 0x000134B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006341, RefRangeEnd = 1006342, XrefRangeStart = 1006308, XrefRangeEnd = 1006341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lookup(IEqualityComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.NativeMethodInfoPtr__ctor_Private_Void_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00015304 File Offset: 0x00013504
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1006346, RefRangeEnd = 1006353, XrefRangeStart = 1006342, XrefRangeEnd = 1006346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_IGrouping_2_TKey_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IGrouping<TKey, TElement>>>(intPtr3) : null;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00015344 File Offset: 0x00013544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006353, XrefRangeEnd = 1006357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00015384 File Offset: 0x00013584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006357, XrefRangeEnd = 1006359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalGetHashCode(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.NativeMethodInfoPtr_InternalGetHashCode_Internal_Int32_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00015408 File Offset: 0x00013608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006363, RefRangeEnd = 1006364, XrefRangeStart = 1006359, XrefRangeEnd = 1006363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lookup<TKey, TElement>.Grouping GetGrouping(TKey key, bool create)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref create;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.NativeMethodInfoPtr_GetGrouping_Internal_Grouping_TKey_TElement_TKey_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Lookup<TKey, TElement>.Grouping>(intPtr4) : null;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0001549C File Offset: 0x0001369C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006364, XrefRangeEnd = 1006388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.NativeMethodInfoPtr_Resize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000022D6 File Offset: 0x000004D6
		public Lookup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000125 RID: 293 RVA: 0x000154D0 File Offset: 0x000136D0
		// (set) Token: 0x06000126 RID: 294 RVA: 0x000022DF File Offset: 0x000004DF
		public unsafe IEqualityComparer<TKey> comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00015500 File Offset: 0x00013700
		// (set) Token: 0x06000128 RID: 296 RVA: 0x000022FE File Offset: 0x000004FE
		public unsafe Il2CppReferenceArray<Lookup<TKey, TElement>.Grouping> groupings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.NativeFieldInfoPtr_groupings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Lookup<TKey, TElement>.Grouping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.NativeFieldInfoPtr_groupings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00015530 File Offset: 0x00013730
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000231D File Offset: 0x0000051D
		public unsafe Lookup<TKey, TElement>.Grouping lastGrouping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.NativeFieldInfoPtr_lastGrouping);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lookup<TKey, TElement>.Grouping>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.NativeFieldInfoPtr_lastGrouping), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00015560 File Offset: 0x00013760
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0000233C File Offset: 0x0000053C
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr_groupings;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeFieldInfoPtr_lastGrouping;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_Lookup_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_IEqualityComparer_1_TKey_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_IGrouping_2_TKey_TElement_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetHashCode_Internal_Int32_TKey_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_GetGrouping_Internal_Grouping_TKey_TElement_TKey_Boolean_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Private_Void_0;

		// Token: 0x020001B6 RID: 438
		public class Grouping : Object
		{
			// Token: 0x060015BE RID: 5566 RVA: 0x0006C090 File Offset: 0x0006A290
			// Note: this type is marked as 'beforefieldinit'.
			static Grouping()
			{
				Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, "Grouping"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr);
				Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, "key");
				Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, "hashCode");
				Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, "elements");
				Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, "count");
				Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_hashNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, "hashNext");
				Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, "next");
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_Add_Internal_Void_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663734);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663735);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663736);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663737);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663738);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663739);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Add_Private_Virtual_Final_New_Void_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663740);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663741);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Contains_Private_Virtual_Final_New_Boolean_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663742);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__CopyTo_Private_Virtual_Final_New_Void_Il2CppArrayBase_1_TElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663743);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Remove_Private_Virtual_Final_New_Boolean_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663744);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__IndexOf_Private_Virtual_Final_New_Int32_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663745);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__Insert_Private_Virtual_Final_New_Void_Int32_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663746);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__RemoveAt_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663747);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__get_Item_Private_Virtual_Final_New_get_TElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663748);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__set_Item_Private_Virtual_Final_New_set_Void_Int32_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663749);
				Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, 100663750);
			}

			// Token: 0x060015BF RID: 5567 RVA: 0x0006C2D4 File Offset: 0x0006A4D4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1006261, RefRangeEnd = 1006262, XrefRangeStart = 1006259, XrefRangeEnd = 1006261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Add(TElement element)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TElement).IsValueType)
					{
						TElement telement = element;
						intPtr = ((telement is string) ? IL2CPP.ManagedStringToIl2Cpp(telement as string) : IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref element;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_Add_Internal_Void_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x060015C0 RID: 5568 RVA: 0x0006C34C File Offset: 0x0006A54C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006262, XrefRangeEnd = 1006266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator<TElement> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TElement>>(intPtr3) : null;
			}

			// Token: 0x060015C1 RID: 5569 RVA: 0x0006C38C File Offset: 0x0006A58C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006266, XrefRangeEnd = 1006270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x17000689 RID: 1673
			// (get) Token: 0x060015C2 RID: 5570 RVA: 0x0006C3CC File Offset: 0x0006A5CC
			public unsafe virtual TKey Key
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
				}
			}

			// Token: 0x1700068A RID: 1674
			// (get) Token: 0x060015C3 RID: 5571 RVA: 0x0006C408 File Offset: 0x0006A608
			public unsafe virtual int System.Collections.Generic.ICollection<TElement>.Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700068B RID: 1675
			// (get) Token: 0x060015C4 RID: 5572 RVA: 0x0006C444 File Offset: 0x0006A644
			public unsafe virtual bool System.Collections.Generic.ICollection<TElement>.IsReadOnly
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060015C5 RID: 5573 RVA: 0x0006C480 File Offset: 0x0006A680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006270, XrefRangeEnd = 1006272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_Generic_ICollection_TElement__Add(TElement item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TElement).IsValueType)
					{
						TElement telement = item;
						intPtr = ((telement is string) ? IL2CPP.ManagedStringToIl2Cpp(telement as string) : IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Add_Private_Virtual_Final_New_Void_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x060015C6 RID: 5574 RVA: 0x0006C4F8 File Offset: 0x0006A6F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006272, XrefRangeEnd = 1006275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_Generic_ICollection_TElement__Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015C7 RID: 5575 RVA: 0x0006C52C File Offset: 0x0006A72C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006275, XrefRangeEnd = 1006276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_Generic_ICollection_TElement__Contains(TElement item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TElement).IsValueType)
					{
						TElement telement = item;
						intPtr = ((telement is string) ? IL2CPP.ManagedStringToIl2Cpp(telement as string) : IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Contains_Private_Virtual_Final_New_Boolean_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x060015C8 RID: 5576 RVA: 0x0006C5B0 File Offset: 0x0006A7B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006276, XrefRangeEnd = 1006277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_Generic_ICollection_TElement__CopyTo(Il2CppArrayBase<TElement> array, int arrayIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__CopyTo_Private_Virtual_Final_New_Void_Il2CppArrayBase_1_TElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015C9 RID: 5577 RVA: 0x0006C600 File Offset: 0x0006A800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_Generic_ICollection_TElement__Remove(TElement item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TElement).IsValueType)
					{
						TElement telement = item;
						intPtr = ((telement is string) ? IL2CPP.ManagedStringToIl2Cpp(telement as string) : IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Remove_Private_Virtual_Final_New_Boolean_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x060015CA RID: 5578 RVA: 0x0006C684 File Offset: 0x0006A884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006277, XrefRangeEnd = 1006278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Collections_Generic_IList_TElement__IndexOf(TElement item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TElement).IsValueType)
					{
						TElement telement = item;
						intPtr = ((telement is string) ? IL2CPP.ManagedStringToIl2Cpp(telement as string) : IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__IndexOf_Private_Virtual_Final_New_Int32_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x060015CB RID: 5579 RVA: 0x0006C708 File Offset: 0x0006A908
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006278, XrefRangeEnd = 1006280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_Generic_IList_TElement__Insert(int index, TElement item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				if (!typeof(TElement).IsValueType)
				{
					TElement telement = item;
					intPtr = ((telement is string) ? IL2CPP.ManagedStringToIl2Cpp(telement as string) : IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__Insert_Private_Virtual_Final_New_Void_Int32_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x060015CC RID: 5580 RVA: 0x0006C790 File Offset: 0x0006A990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_Generic_IList_TElement__RemoveAt(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__RemoveAt_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700068C RID: 1676
			// (get) Token: 0x060015CD RID: 5581 RVA: 0x0006C7D0 File Offset: 0x0006A9D0
			// (set) Token: 0x060015CE RID: 5582 RVA: 0x0006C818 File Offset: 0x0006AA18
			public unsafe virtual TElement System.Collections.Generic.IList<TElement>.Item
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__get_Item_Private_Virtual_Final_New_get_TElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<TElement>(intPtr, false, true);
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
					}
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr;
					if (!typeof(TElement).IsValueType)
					{
						TElement telement = value;
						intPtr = ((telement is string) ? IL2CPP.ManagedStringToIl2Cpp(telement as string) : IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__set_Item_Private_Virtual_Final_New_set_Void_Int32_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x060015CF RID: 5583 RVA: 0x0006C8A0 File Offset: 0x0006AAA0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Grouping()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015D0 RID: 5584 RVA: 0x0000912F File Offset: 0x0000732F
			public Grouping(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000683 RID: 1667
			// (get) Token: 0x060015D1 RID: 5585 RVA: 0x0006C8DC File Offset: 0x0006AADC
			// (set) Token: 0x060015D2 RID: 5586 RVA: 0x0006C904 File Offset: 0x0006AB04
			public unsafe TKey key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_key);
					return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_key);
					Type typeFromHandle = typeof(TKey);
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

			// Token: 0x17000684 RID: 1668
			// (get) Token: 0x060015D3 RID: 5587 RVA: 0x0006C9AC File Offset: 0x0006ABAC
			// (set) Token: 0x060015D4 RID: 5588 RVA: 0x00009138 File Offset: 0x00007338
			public unsafe int hashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_hashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_hashCode)) = value;
				}
			}

			// Token: 0x17000685 RID: 1669
			// (get) Token: 0x060015D5 RID: 5589 RVA: 0x0006C9D4 File Offset: 0x0006ABD4
			// (set) Token: 0x060015D6 RID: 5590 RVA: 0x00009153 File Offset: 0x00007353
			public unsafe Il2CppArrayBase<TElement> elements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_elements);
					return Il2CppArrayBase<TElement>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000686 RID: 1670
			// (get) Token: 0x060015D7 RID: 5591 RVA: 0x0006C9FC File Offset: 0x0006ABFC
			// (set) Token: 0x060015D8 RID: 5592 RVA: 0x00009172 File Offset: 0x00007372
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x17000687 RID: 1671
			// (get) Token: 0x060015D9 RID: 5593 RVA: 0x0006CA24 File Offset: 0x0006AC24
			// (set) Token: 0x060015DA RID: 5594 RVA: 0x0000918D File Offset: 0x0000738D
			public unsafe Lookup<TKey, TElement>.Grouping hashNext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_hashNext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lookup<TKey, TElement>.Grouping>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_hashNext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000688 RID: 1672
			// (get) Token: 0x060015DB RID: 5595 RVA: 0x0006CA54 File Offset: 0x0006AC54
			// (set) Token: 0x060015DC RID: 5596 RVA: 0x000091AC File Offset: 0x000073AC
			public unsafe Lookup<TKey, TElement>.Grouping next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lookup<TKey, TElement>.Grouping>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F77 RID: 3959
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04000F78 RID: 3960
			private static readonly IntPtr NativeFieldInfoPtr_hashCode;

			// Token: 0x04000F79 RID: 3961
			private static readonly IntPtr NativeFieldInfoPtr_elements;

			// Token: 0x04000F7A RID: 3962
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04000F7B RID: 3963
			private static readonly IntPtr NativeFieldInfoPtr_hashNext;

			// Token: 0x04000F7C RID: 3964
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x04000F7D RID: 3965
			private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_TElement_0;

			// Token: 0x04000F7E RID: 3966
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TElement_0;

			// Token: 0x04000F7F RID: 3967
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04000F80 RID: 3968
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_TKey_0;

			// Token: 0x04000F81 RID: 3969
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__get_Count_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000F82 RID: 3970
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000F83 RID: 3971
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Add_Private_Virtual_Final_New_Void_TElement_0;

			// Token: 0x04000F84 RID: 3972
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Clear_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F85 RID: 3973
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Contains_Private_Virtual_Final_New_Boolean_TElement_0;

			// Token: 0x04000F86 RID: 3974
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__CopyTo_Private_Virtual_Final_New_Void_Il2CppArrayBase_1_TElement_Int32_0;

			// Token: 0x04000F87 RID: 3975
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TElement__Remove_Private_Virtual_Final_New_Boolean_TElement_0;

			// Token: 0x04000F88 RID: 3976
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__IndexOf_Private_Virtual_Final_New_Int32_TElement_0;

			// Token: 0x04000F89 RID: 3977
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__Insert_Private_Virtual_Final_New_Void_Int32_TElement_0;

			// Token: 0x04000F8A RID: 3978
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__RemoveAt_Private_Virtual_Final_New_Void_Int32_0;

			// Token: 0x04000F8B RID: 3979
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__get_Item_Private_Virtual_Final_New_get_TElement_Int32_0;

			// Token: 0x04000F8C RID: 3980
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_TElement__set_Item_Private_Virtual_Final_New_set_Void_Int32_TElement_0;

			// Token: 0x04000F8D RID: 3981
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000366 RID: 870
			[ObfuscatedName("System.Linq.Lookup`2+Grouping+<GetEnumerator>d__7")]
			public sealed class _GetEnumerator_d__7 : Object
			{
				// Token: 0x06001C5B RID: 7259 RVA: 0x00085A10 File Offset: 0x00083C10
				// Note: this type is marked as 'beforefieldinit'.
				static _GetEnumerator_d__7()
				{
					Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping>.NativeClassPtr, "<GetEnumerator>d__7"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr);
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, "<>1__state");
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, "<>2__current");
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, "<>4__this");
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, "<i>5__2");
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, 100663751);
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, 100663752);
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, 100663753);
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TElement__get_Current_Private_Virtual_Final_New_get_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, 100663754);
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, 100663755);
					Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr, 100663756);
				}

				// Token: 0x06001C5C RID: 7260 RVA: 0x00085B50 File Offset: 0x00083D50
				[CallerCount(73)]
				[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _GetEnumerator_d__7(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001C5D RID: 7261 RVA: 0x00085B98 File Offset: 0x00083D98
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C5E RID: 7262 RVA: 0x00085BCC File Offset: 0x00083DCC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006256, XrefRangeEnd = 1006258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700072A RID: 1834
				// (get) Token: 0x06001C5F RID: 7263 RVA: 0x00085C08 File Offset: 0x00083E08
				public unsafe TElement System.Collections.Generic.IEnumerator<TElement>.Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TElement__get_Current_Private_Virtual_Final_New_get_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<TElement>(intPtr, false, true);
					}
				}

				// Token: 0x06001C60 RID: 7264 RVA: 0x00085C44 File Offset: 0x00083E44
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700072B RID: 1835
				// (get) Token: 0x06001C61 RID: 7265 RVA: 0x00085C78 File Offset: 0x00083E78
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006258, XrefRangeEnd = 1006259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06001C62 RID: 7266 RVA: 0x0000AD3A File Offset: 0x00008F3A
				public _GetEnumerator_d__7(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000726 RID: 1830
				// (get) Token: 0x06001C63 RID: 7267 RVA: 0x00085CB8 File Offset: 0x00083EB8
				// (set) Token: 0x06001C64 RID: 7268 RVA: 0x0000AD43 File Offset: 0x00008F43
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000727 RID: 1831
				// (get) Token: 0x06001C65 RID: 7269 RVA: 0x00085CE0 File Offset: 0x00083EE0
				// (set) Token: 0x06001C66 RID: 7270 RVA: 0x00085D08 File Offset: 0x00083F08
				public unsafe TElement __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr___2__current);
						return IL2CPP.PointerToValueGeneric<TElement>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr___2__current);
						Type typeFromHandle = typeof(TElement);
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

				// Token: 0x17000728 RID: 1832
				// (get) Token: 0x06001C67 RID: 7271 RVA: 0x00085DB0 File Offset: 0x00083FB0
				// (set) Token: 0x06001C68 RID: 7272 RVA: 0x0000AD5E File Offset: 0x00008F5E
				public unsafe Lookup<TKey, TElement>.Grouping __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lookup<TKey, TElement>.Grouping>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000729 RID: 1833
				// (get) Token: 0x06001C69 RID: 7273 RVA: 0x00085DE0 File Offset: 0x00083FE0
				// (set) Token: 0x06001C6A RID: 7274 RVA: 0x0000AD7D File Offset: 0x00008F7D
				public unsafe int _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>.Grouping._GetEnumerator_d__7.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x04001321 RID: 4897
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04001322 RID: 4898
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04001323 RID: 4899
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04001324 RID: 4900
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x04001325 RID: 4901
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04001326 RID: 4902
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001327 RID: 4903
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04001328 RID: 4904
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TElement__get_Current_Private_Virtual_Final_New_get_TElement_0;

				// Token: 0x04001329 RID: 4905
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400132A RID: 4906
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020001B7 RID: 439
		[ObfuscatedName("System.Linq.Lookup`2+<GetEnumerator>d__12")]
		public sealed class _GetEnumerator_d__12 : Object
		{
			// Token: 0x060015DD RID: 5597 RVA: 0x0006CA84 File Offset: 0x0006AC84
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__12()
			{
				Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lookup<TKey, TElement>>.NativeClassPtr, "<GetEnumerator>d__12"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr);
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, "<>1__state");
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, "<>2__current");
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, "<>4__this");
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr__g_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, "<g>5__2");
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, 100663757);
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, 100663758);
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, 100663759);
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IGrouping_2_TKey_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, 100663760);
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, 100663761);
				Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr, 100663762);
			}

			// Token: 0x060015DE RID: 5598 RVA: 0x0006CBC4 File Offset: 0x0006ADC4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lookup<TKey, TElement>._GetEnumerator_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060015DF RID: 5599 RVA: 0x0006CC0C File Offset: 0x0006AE0C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015E0 RID: 5600 RVA: 0x0006CC40 File Offset: 0x0006AE40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006280, XrefRangeEnd = 1006281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000691 RID: 1681
			// (get) Token: 0x060015E1 RID: 5601 RVA: 0x0006CC7C File Offset: 0x0006AE7C
			public unsafe IGrouping<TKey, TElement> prop_IGrouping_2_TKey_TElement_0
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IGrouping_2_TKey_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGrouping<TKey, TElement>>(intPtr3) : null;
				}
			}

			// Token: 0x060015E2 RID: 5602 RVA: 0x0006CCBC File Offset: 0x0006AEBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000692 RID: 1682
			// (get) Token: 0x060015E3 RID: 5603 RVA: 0x0006CCF0 File Offset: 0x0006AEF0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060015E4 RID: 5604 RVA: 0x000091CB File Offset: 0x000073CB
			public _GetEnumerator_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700068D RID: 1677
			// (get) Token: 0x060015E5 RID: 5605 RVA: 0x0006CD30 File Offset: 0x0006AF30
			// (set) Token: 0x060015E6 RID: 5606 RVA: 0x000091D4 File Offset: 0x000073D4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700068E RID: 1678
			// (get) Token: 0x060015E7 RID: 5607 RVA: 0x0006CD58 File Offset: 0x0006AF58
			// (set) Token: 0x060015E8 RID: 5608 RVA: 0x000091EF File Offset: 0x000073EF
			public unsafe IGrouping<TKey, TElement> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGrouping<TKey, TElement>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068F RID: 1679
			// (get) Token: 0x060015E9 RID: 5609 RVA: 0x0006CD88 File Offset: 0x0006AF88
			// (set) Token: 0x060015EA RID: 5610 RVA: 0x0000920E File Offset: 0x0000740E
			public unsafe Lookup<TKey, TElement> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lookup<TKey, TElement>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000690 RID: 1680
			// (get) Token: 0x060015EB RID: 5611 RVA: 0x0006CDB8 File Offset: 0x0006AFB8
			// (set) Token: 0x060015EC RID: 5612 RVA: 0x0000922D File Offset: 0x0000742D
			public unsafe Lookup<TKey, TElement>.Grouping _g_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr__g_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lookup<TKey, TElement>.Grouping>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lookup<TKey, TElement>._GetEnumerator_d__12.NativeFieldInfoPtr__g_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F8E RID: 3982
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F8F RID: 3983
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F90 RID: 3984
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000F91 RID: 3985
			private static readonly IntPtr NativeFieldInfoPtr__g_5__2;

			// Token: 0x04000F92 RID: 3986
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F93 RID: 3987
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F94 RID: 3988
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F95 RID: 3989
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IGrouping_2_TKey_TElement_0;

			// Token: 0x04000F96 RID: 3990
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F97 RID: 3991
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020001B8 RID: 440
		private sealed class MethodInfoStoreGeneric_Create_Internal_Static_Lookup_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0
		{
			// Token: 0x060015ED RID: 5613 RVA: 0x0006CDE8 File Offset: 0x0006AFE8
			// Note: this type is marked as 'beforefieldinit'.
			static MethodInfoStoreGeneric_Create_Internal_Static_Lookup_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0()
			{
				/*
An exception occurred when decompiling this method (060015ED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Il2CppSystem.Linq.Lookup`2/MethodInfoStoreGeneric_Create_Internal_Static_Lookup_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 881
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
			}

			// Token: 0x04000F98 RID: 3992
			internal static IntPtr Pointer;
		}
	}
}
