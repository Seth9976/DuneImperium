using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Utils.enums
{
	// Token: 0x0200003C RID: 60
	public class Either<TLeft, TRight> : Object
	{
		// Token: 0x06000270 RID: 624 RVA: 0x0000EA34 File Offset: 0x0000CC34
		// Note: this type is marked as 'beforefieldinit'.
		static Either()
		{
			Il2CppClassPointerStore<Either<TLeft, TRight>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Utils.dll", "Utils.enums", "Either`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TLeft>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRight>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Either<TLeft, TRight>>.NativeClassPtr);
			Either<TLeft, TRight>.NativeMethodInfoPtr_Match_Public_U_Func_2_TLeft_U_Func_2_TRight_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Either<TLeft, TRight>>.NativeClassPtr, 100663883);
			Either<TLeft, TRight>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Either<TLeft, TRight>>.NativeClassPtr, 100663884);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000EADC File Offset: 0x0000CCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184472, XrefRangeEnd = 1184478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public U Match<U>(Func<TLeft, U> handleLeft, Func<TRight, U> handleRight)
		{
			/*
An exception occurred when decompiling this method (06000271)

ICSharpCode.Decompiler.DecompilerException: Error decompiling U Utils.enums.Either`2::Match<U>(Il2CppSystem.Func`2<TLeft,U>,Il2CppSystem.Func`2<TRight,U>)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
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

		// Token: 0x06000272 RID: 626 RVA: 0x0000EB38 File Offset: 0x0000CD38
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Either()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Either<TLeft, TRight>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Either<TLeft, TRight>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002B0A File Offset: 0x00000D0A
		public Either(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_U_Func_2_TLeft_U_Func_2_TRight_U_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020000B8 RID: 184
		public sealed class Left : Either<TLeft, TRight>
		{
			// Token: 0x060005B4 RID: 1460 RVA: 0x00019F88 File Offset: 0x00018188
			// Note: this type is marked as 'beforefieldinit'.
			static Left()
			{
				Il2CppClassPointerStore<Either<TLeft, TRight>.Left>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Either<TLeft, TRight>>.NativeClassPtr, "Left"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TLeft>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRight>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Either<TLeft, TRight>.Left>.NativeClassPtr);
				Either<TLeft, TRight>.Left.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Either<TLeft, TRight>.Left>.NativeClassPtr, "<Value>k__BackingField");
				Either<TLeft, TRight>.Left.NativeMethodInfoPtr_get_Value_Public_get_TLeft_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Either<TLeft, TRight>.Left>.NativeClassPtr, 100663885);
				Either<TLeft, TRight>.Left.NativeMethodInfoPtr__ctor_Public_Void_TLeft_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Either<TLeft, TRight>.Left>.NativeClassPtr, 100663886);
			}

			// Token: 0x1700016D RID: 365
			// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0001A03C File Offset: 0x0001823C
			public unsafe TLeft Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Either<TLeft, TRight>.Left.NativeMethodInfoPtr_get_Value_Public_get_TLeft_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TLeft>(intPtr, false, true);
				}
			}

			// Token: 0x060005B6 RID: 1462 RVA: 0x0001A078 File Offset: 0x00018278
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184469, XrefRangeEnd = 1184472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Left(TLeft value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Either<TLeft, TRight>.Left>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TLeft).IsValueType)
					{
						TLeft tleft = value;
						intPtr = ((tleft is string) ? IL2CPP.ManagedStringToIl2Cpp(tleft as string) : IL2CPP.Il2CppObjectBaseToPtr(tleft as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Either<TLeft, TRight>.Left.NativeMethodInfoPtr__ctor_Public_Void_TLeft_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x060005B7 RID: 1463 RVA: 0x000044B8 File Offset: 0x000026B8
			public Left(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700016C RID: 364
			// (get) Token: 0x060005B8 RID: 1464 RVA: 0x0001A0FC File Offset: 0x000182FC
			// (set) Token: 0x060005B9 RID: 1465 RVA: 0x0001A124 File Offset: 0x00018324
			public unsafe TLeft _Value_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Either<TLeft, TRight>.Left.NativeFieldInfoPtr__Value_k__BackingField);
					return IL2CPP.PointerToValueGeneric<TLeft>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Either<TLeft, TRight>.Left.NativeFieldInfoPtr__Value_k__BackingField);
					Type typeFromHandle = typeof(TLeft);
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

			// Token: 0x040003B7 RID: 951
			private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

			// Token: 0x040003B8 RID: 952
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_TLeft_0;

			// Token: 0x040003B9 RID: 953
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TLeft_0;
		}

		// Token: 0x020000B9 RID: 185
		public sealed class Right : Either<TLeft, TRight>
		{
			// Token: 0x060005BA RID: 1466 RVA: 0x0001A1CC File Offset: 0x000183CC
			// Note: this type is marked as 'beforefieldinit'.
			static Right()
			{
				Il2CppClassPointerStore<Either<TLeft, TRight>.Right>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Either<TLeft, TRight>>.NativeClassPtr, "Right"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TLeft>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRight>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Either<TLeft, TRight>.Right>.NativeClassPtr);
				Either<TLeft, TRight>.Right.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Either<TLeft, TRight>.Right>.NativeClassPtr, "<Value>k__BackingField");
				Either<TLeft, TRight>.Right.NativeMethodInfoPtr_get_Value_Public_get_TRight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Either<TLeft, TRight>.Right>.NativeClassPtr, 100663887);
				Either<TLeft, TRight>.Right.NativeMethodInfoPtr__ctor_Public_Void_TRight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Either<TLeft, TRight>.Right>.NativeClassPtr, 100663888);
			}

			// Token: 0x1700016F RID: 367
			// (get) Token: 0x060005BB RID: 1467 RVA: 0x0001A280 File Offset: 0x00018480
			public unsafe TRight Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Either<TLeft, TRight>.Right.NativeMethodInfoPtr_get_Value_Public_get_TRight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TRight>(intPtr, false, true);
				}
			}

			// Token: 0x060005BC RID: 1468 RVA: 0x0001A2BC File Offset: 0x000184BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Right(TRight value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Either<TLeft, TRight>.Right>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TRight).IsValueType)
					{
						TRight tright = value;
						intPtr = ((tright is string) ? IL2CPP.ManagedStringToIl2Cpp(tright as string) : IL2CPP.Il2CppObjectBaseToPtr(tright as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Either<TLeft, TRight>.Right.NativeMethodInfoPtr__ctor_Public_Void_TRight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x060005BD RID: 1469 RVA: 0x000044C1 File Offset: 0x000026C1
			public Right(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700016E RID: 366
			// (get) Token: 0x060005BE RID: 1470 RVA: 0x0001A340 File Offset: 0x00018540
			// (set) Token: 0x060005BF RID: 1471 RVA: 0x0001A368 File Offset: 0x00018568
			public unsafe TRight _Value_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Either<TLeft, TRight>.Right.NativeFieldInfoPtr__Value_k__BackingField);
					return IL2CPP.PointerToValueGeneric<TRight>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Either<TLeft, TRight>.Right.NativeFieldInfoPtr__Value_k__BackingField);
					Type typeFromHandle = typeof(TRight);
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

			// Token: 0x040003BA RID: 954
			private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

			// Token: 0x040003BB RID: 955
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_TRight_0;

			// Token: 0x040003BC RID: 956
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TRight_0;
		}

		// Token: 0x020000BA RID: 186
		private sealed class MethodInfoStoreGeneric_Match_Public_U_Func_2_TLeft_U_Func_2_TRight_U_0
		{
			// Token: 0x060005C0 RID: 1472 RVA: 0x0001A410 File Offset: 0x00018610
			// Note: this type is marked as 'beforefieldinit'.
			static MethodInfoStoreGeneric_Match_Public_U_Func_2_TLeft_U_Func_2_TRight_U_0()
			{
				/*
An exception occurred when decompiling this method (060005C0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Utils.enums.Either`2/MethodInfoStoreGeneric_Match_Public_U_Func_2_TLeft_U_Func_2_TRight_U_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
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

			// Token: 0x040003BD RID: 957
			internal static IntPtr Pointer;
		}
	}
}
