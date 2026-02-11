using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Unity.Properties
{
	// Token: 0x02000009 RID: 9
	public class Property<TContainer, TValue> : Object
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00003BF8 File Offset: 0x00001DF8
		// Note: this type is marked as 'beforefieldinit'.
		static Property()
		{
			Il2CppClassPointerStore<Property<TContainer, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "Property`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Property<TContainer, TValue>>.NativeClassPtr);
			Property<TContainer, TValue>.NativeFieldInfoPtr_m_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property<TContainer, TValue>>.NativeClassPtr, "m_Attributes");
			Property<TContainer, TValue>.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property<TContainer, TValue>>.NativeClassPtr, 100663304);
			Property<TContainer, TValue>.NativeMethodInfoPtr_DeclaredValueType_Public_Virtual_Final_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property<TContainer, TValue>>.NativeClassPtr, 100663305);
			Property<TContainer, TValue>.NativeMethodInfoPtr_AddAttribute_Protected_Void_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property<TContainer, TValue>>.NativeClassPtr, 100663306);
			Property<TContainer, TValue>.NativeMethodInfoPtr_AddAttributes_Protected_Void_IEnumerable_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property<TContainer, TValue>>.NativeClassPtr, 100663307);
			Property<TContainer, TValue>.NativeMethodInfoPtr_Unity_Properties_Internal_IAttributes_AddAttribute_Private_Virtual_Final_New_Void_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property<TContainer, TValue>>.NativeClassPtr, 100663308);
			Property<TContainer, TValue>.NativeMethodInfoPtr_Unity_Properties_Internal_IAttributes_AddAttributes_Private_Virtual_Final_New_Void_IEnumerable_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property<TContainer, TValue>>.NativeClassPtr, 100663309);
			Property<TContainer, TValue>.NativeMethodInfoPtr_HasAttribute_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property<TContainer, TValue>>.NativeClassPtr, 100663310);
			Property<TContainer, TValue>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property<TContainer, TValue>>.NativeClassPtr, 100663311);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00003D2C File Offset: 0x00001F2C
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property<TContainer, TValue>.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003D70 File Offset: 0x00001F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230397, XrefRangeEnd = 1230459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Type DeclaredValueType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property<TContainer, TValue>.NativeMethodInfoPtr_DeclaredValueType_Public_Virtual_Final_New_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230459, XrefRangeEnd = 1230519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAttribute(Attribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property<TContainer, TValue>.NativeMethodInfoPtr_AddAttribute_Protected_Void_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003DF4 File Offset: 0x00001FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230519, XrefRangeEnd = 1230559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAttributes(IEnumerable<Attribute> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property<TContainer, TValue>.NativeMethodInfoPtr_AddAttributes_Protected_Void_IEnumerable_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003E38 File Offset: 0x00002038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230559, XrefRangeEnd = 1230577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unity_Properties_Internal_IAttributes_AddAttribute(Attribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property<TContainer, TValue>.NativeMethodInfoPtr_Unity_Properties_Internal_IAttributes_AddAttribute_Private_Virtual_Final_New_Void_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003E7C File Offset: 0x0000207C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230577, XrefRangeEnd = 1230612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unity_Properties_Internal_IAttributes_AddAttributes(IEnumerable<Attribute> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property<TContainer, TValue>.NativeMethodInfoPtr_Unity_Properties_Internal_IAttributes_AddAttributes_Private_Virtual_Final_New_Void_IEnumerable_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003EC0 File Offset: 0x000020C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230612, XrefRangeEnd = 1230627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public virtual bool HasAttribute<TAttribute>() where TAttribute : Attribute
		{
			/*
An exception occurred when decompiling this method (06000026)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Unity.Properties.Property`2::HasAttribute<TAttribute>()

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

		// Token: 0x06000027 RID: 39 RVA: 0x00003EFC File Offset: 0x000020FC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Property()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Property<TContainer, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property<TContainer, TValue>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002170 File Offset: 0x00000370
		public Property(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003F38 File Offset: 0x00002138
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002179 File Offset: 0x00000379
		public unsafe List<Attribute> m_Attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property<TContainer, TValue>.NativeFieldInfoPtr_m_Attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Attribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property<TContainer, TValue>.NativeFieldInfoPtr_m_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002198 File Offset: 0x00000398
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000021A0 File Offset: 0x000003A0
		public List<Attribute> Unity.Properties.Internal.IAttributes.Attributes
		{
			get
			{
				return this.m_Attributes;
			}
			set
			{
				this.m_Attributes = value;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000021A9 File Offset: 0x000003A9
		public void Accept(IPropertyVisitor visitor, ref TContainer container)
		{
			visitor.Visit<TContainer, TValue>(this, ref container);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000021B4 File Offset: 0x000003B4
		public Object Unity.Properties.IProperty<TContainer>.GetValue(ref TContainer container)
		{
			return this.GetValue(ref container);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000021C2 File Offset: 0x000003C2
		public void Unity.Properties.IProperty<TContainer>.SetValue(ref TContainer container, Object value)
		{
			this.SetValue(ref container, TypeConversion.Convert<Object, TValue>(ref value));
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003F68 File Offset: 0x00002168
		public TAttribute GetAttribute<TAttribute>() where TAttribute : Attribute
		{
			int num = 0;
			TAttribute tattribute;
			for (;;)
			{
				int num2 = num;
				List<Attribute> attributes = this.m_Attributes;
				Nullable<int> nullable = ((attributes != null) ? new Nullable<int>(attributes.Count) : null);
				if (!((num2 < nullable.GetValueOrDefault()) & nullable.HasValue))
				{
					goto Block_3;
				}
				tattribute = this.m_Attributes[num].TryCast<TAttribute>().Cast<TAttribute>();
				bool flag = tattribute != null;
				if (flag)
				{
					break;
				}
				num++;
			}
			return tattribute;
			Block_3:
			return default(TAttribute);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000021D3 File Offset: 0x000003D3
		public IEnumerable<TAttribute> GetAttributes<TAttribute>() where TAttribute : Attribute
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000021E0 File Offset: 0x000003E0
		public IEnumerable<Attribute> GetAttributes()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_m_Attributes;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_DeclaredValueType_Public_Virtual_Final_New_Type_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Protected_Void_Attribute_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_AddAttributes_Protected_Void_IEnumerable_1_Attribute_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_Unity_Properties_Internal_IAttributes_AddAttribute_Private_Virtual_Final_New_Void_Attribute_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_Unity_Properties_Internal_IAttributes_AddAttributes_Private_Virtual_Final_New_Void_IEnumerable_1_Attribute_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_HasAttribute_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200005B RID: 91
		private sealed class MethodInfoStoreGeneric_HasAttribute_Public_Virtual_Final_New_Boolean_0
		{
			// Token: 0x060001E9 RID: 489 RVA: 0x000084D0 File Offset: 0x000066D0
			// Note: this type is marked as 'beforefieldinit'.
			static MethodInfoStoreGeneric_HasAttribute_Public_Virtual_Final_New_Boolean_0()
			{
				/*
An exception occurred when decompiling this method (060001E9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Unity.Properties.Property`2/MethodInfoStoreGeneric_HasAttribute_Public_Virtual_Final_New_Boolean_0`1::.cctor()

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

			// Token: 0x040000E6 RID: 230
			internal static IntPtr Pointer;
		}
	}
}
