using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq.Expressions;

namespace Il2CppSystem.Dynamic
{
	// Token: 0x02000115 RID: 277
	public class BindingRestrictions : Object
	{
		// Token: 0x0600106E RID: 4206 RVA: 0x00056624 File Offset: 0x00054824
		// Note: this type is marked as 'beforefieldinit'.
		static BindingRestrictions()
		{
			Il2CppClassPointerStore<BindingRestrictions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic", "BindingRestrictions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingRestrictions>.NativeClassPtr);
			BindingRestrictions.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingRestrictions>.NativeClassPtr, "Empty");
			BindingRestrictions.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions>.NativeClassPtr, 100666357);
			BindingRestrictions.NativeMethodInfoPtr_GetExpression_Internal_Abstract_Virtual_New_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions>.NativeClassPtr, 100666358);
			BindingRestrictions.NativeMethodInfoPtr_Merge_Public_BindingRestrictions_BindingRestrictions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions>.NativeClassPtr, 100666359);
			BindingRestrictions.NativeMethodInfoPtr_GetTypeRestriction_Public_Static_BindingRestrictions_Expression_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions>.NativeClassPtr, 100666360);
			BindingRestrictions.NativeMethodInfoPtr_GetTypeRestriction_Internal_Static_BindingRestrictions_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions>.NativeClassPtr, 100666361);
			BindingRestrictions.NativeMethodInfoPtr_GetInstanceRestriction_Public_Static_BindingRestrictions_Expression_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions>.NativeClassPtr, 100666362);
			BindingRestrictions.NativeMethodInfoPtr_ToExpression_Public_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions>.NativeClassPtr, 100666363);
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x000566F4 File Offset: 0x000548F4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingRestrictions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindingRestrictions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00056730 File Offset: 0x00054930
		[CallerCount(0)]
		public unsafe virtual Expression GetExpression()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BindingRestrictions.NativeMethodInfoPtr_GetExpression_Internal_Abstract_Virtual_New_Expression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x0005677C File Offset: 0x0005497C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1028206, RefRangeEnd = 1028212, XrefRangeStart = 1028188, XrefRangeEnd = 1028206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingRestrictions Merge(BindingRestrictions restrictions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(restrictions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.NativeMethodInfoPtr_Merge_Public_BindingRestrictions_BindingRestrictions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BindingRestrictions>(intPtr3) : null;
			}
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x000567CC File Offset: 0x000549CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1028227, RefRangeEnd = 1028228, XrefRangeStart = 1028212, XrefRangeEnd = 1028227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BindingRestrictions GetTypeRestriction(Expression expression, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expression);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.NativeMethodInfoPtr_GetTypeRestriction_Public_Static_BindingRestrictions_Expression_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BindingRestrictions>(intPtr3) : null;
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x00056824 File Offset: 0x00054A24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1028248, RefRangeEnd = 1028250, XrefRangeStart = 1028228, XrefRangeEnd = 1028248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BindingRestrictions GetTypeRestriction(DynamicMetaObject obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.NativeMethodInfoPtr_GetTypeRestriction_Internal_Static_BindingRestrictions_DynamicMetaObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BindingRestrictions>(intPtr3) : null;
			}
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x00056868 File Offset: 0x00054A68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1028262, RefRangeEnd = 1028263, XrefRangeStart = 1028250, XrefRangeEnd = 1028262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BindingRestrictions GetInstanceRestriction(Expression expression, Object instance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expression);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.NativeMethodInfoPtr_GetInstanceRestriction_Public_Static_BindingRestrictions_Expression_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BindingRestrictions>(intPtr3) : null;
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x000568C0 File Offset: 0x00054AC0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 660290, RefRangeEnd = 660296, XrefRangeStart = 660290, XrefRangeEnd = 660296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression ToExpression()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.NativeMethodInfoPtr_ToExpression_Public_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x00007128 File Offset: 0x00005328
		public BindingRestrictions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x00056900 File Offset: 0x00054B00
		// (set) Token: 0x06001078 RID: 4216 RVA: 0x00007131 File Offset: 0x00005331
		public unsafe static BindingRestrictions Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BindingRestrictions.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BindingRestrictions>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BindingRestrictions.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr_GetExpression_Internal_Abstract_Virtual_New_Expression_0;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr_Merge_Public_BindingRestrictions_BindingRestrictions_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeRestriction_Public_Static_BindingRestrictions_Expression_Type_0;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeRestriction_Internal_Static_BindingRestrictions_DynamicMetaObject_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr_GetInstanceRestriction_Public_Static_BindingRestrictions_Expression_Object_0;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr_ToExpression_Public_Expression_0;

		// Token: 0x0200033D RID: 829
		public sealed class TestBuilder : Object
		{
			// Token: 0x06001B7A RID: 7034 RVA: 0x00082600 File Offset: 0x00080800
			// Note: this type is marked as 'beforefieldinit'.
			static TestBuilder()
			{
				Il2CppClassPointerStore<BindingRestrictions.TestBuilder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BindingRestrictions>.NativeClassPtr, "TestBuilder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingRestrictions.TestBuilder>.NativeClassPtr);
				BindingRestrictions.TestBuilder.NativeFieldInfoPtr__unique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingRestrictions.TestBuilder>.NativeClassPtr, "_unique");
				BindingRestrictions.TestBuilder.NativeFieldInfoPtr__tests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingRestrictions.TestBuilder>.NativeClassPtr, "_tests");
				BindingRestrictions.TestBuilder.NativeMethodInfoPtr_Append_Internal_Void_BindingRestrictions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions.TestBuilder>.NativeClassPtr, 100666365);
				BindingRestrictions.TestBuilder.NativeMethodInfoPtr_ToExpression_Internal_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions.TestBuilder>.NativeClassPtr, 100666366);
				BindingRestrictions.TestBuilder.NativeMethodInfoPtr_Push_Private_Void_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions.TestBuilder>.NativeClassPtr, 100666367);
				BindingRestrictions.TestBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions.TestBuilder>.NativeClassPtr, 100666368);
			}

			// Token: 0x06001B7B RID: 7035 RVA: 0x000826A4 File Offset: 0x000808A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027961, XrefRangeEnd = 1027980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Append(BindingRestrictions restrictions)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(restrictions);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.TestBuilder.NativeMethodInfoPtr_Append_Internal_Void_BindingRestrictions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B7C RID: 7036 RVA: 0x000826E8 File Offset: 0x000808E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027980, XrefRangeEnd = 1027991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Expression ToExpression()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.TestBuilder.NativeMethodInfoPtr_ToExpression_Internal_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}

			// Token: 0x06001B7D RID: 7037 RVA: 0x00082728 File Offset: 0x00080928
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027991, XrefRangeEnd = 1028007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Push(Expression node, int depth)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.TestBuilder.NativeMethodInfoPtr_Push_Private_Void_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B7E RID: 7038 RVA: 0x00082778 File Offset: 0x00080978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028007, XrefRangeEnd = 1028022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TestBuilder()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindingRestrictions.TestBuilder>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.TestBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B7F RID: 7039 RVA: 0x0000A763 File Offset: 0x00008963
			public TestBuilder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F0 RID: 1776
			// (get) Token: 0x06001B80 RID: 7040 RVA: 0x000827B4 File Offset: 0x000809B4
			// (set) Token: 0x06001B81 RID: 7041 RVA: 0x0000A76C File Offset: 0x0000896C
			public unsafe HashSet<BindingRestrictions> _unique
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.TestBuilder.NativeFieldInfoPtr__unique);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<BindingRestrictions>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.TestBuilder.NativeFieldInfoPtr__unique), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006F1 RID: 1777
			// (get) Token: 0x06001B82 RID: 7042 RVA: 0x000827E4 File Offset: 0x000809E4
			// (set) Token: 0x06001B83 RID: 7043 RVA: 0x0000A78B File Offset: 0x0000898B
			public unsafe Stack<BindingRestrictions.TestBuilder.AndNode> _tests
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.TestBuilder.NativeFieldInfoPtr__tests);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<BindingRestrictions.TestBuilder.AndNode>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.TestBuilder.NativeFieldInfoPtr__tests), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001293 RID: 4755
			private static readonly IntPtr NativeFieldInfoPtr__unique;

			// Token: 0x04001294 RID: 4756
			private static readonly IntPtr NativeFieldInfoPtr__tests;

			// Token: 0x04001295 RID: 4757
			private static readonly IntPtr NativeMethodInfoPtr_Append_Internal_Void_BindingRestrictions_0;

			// Token: 0x04001296 RID: 4758
			private static readonly IntPtr NativeMethodInfoPtr_ToExpression_Internal_Expression_0;

			// Token: 0x04001297 RID: 4759
			private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_Expression_Int32_0;

			// Token: 0x04001298 RID: 4760
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0200036C RID: 876
			public sealed class AndNode : ValueType
			{
				// Token: 0x06001C84 RID: 7300 RVA: 0x000862C8 File Offset: 0x000844C8
				// Note: this type is marked as 'beforefieldinit'.
				static AndNode()
				{
					Il2CppClassPointerStore<BindingRestrictions.TestBuilder.AndNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BindingRestrictions.TestBuilder>.NativeClassPtr, "AndNode");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingRestrictions.TestBuilder.AndNode>.NativeClassPtr);
					BindingRestrictions.TestBuilder.AndNode.NativeFieldInfoPtr_Depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingRestrictions.TestBuilder.AndNode>.NativeClassPtr, "Depth");
					BindingRestrictions.TestBuilder.AndNode.NativeFieldInfoPtr_Node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingRestrictions.TestBuilder.AndNode>.NativeClassPtr, "Node");
				}

				// Token: 0x06001C85 RID: 7301 RVA: 0x0000AE54 File Offset: 0x00009054
				public AndNode(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06001C86 RID: 7302 RVA: 0x0000AE5D File Offset: 0x0000905D
				public AndNode()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindingRestrictions.TestBuilder.AndNode>.NativeClassPtr))
				{
				}

				// Token: 0x17000731 RID: 1841
				// (get) Token: 0x06001C87 RID: 7303 RVA: 0x0008631C File Offset: 0x0008451C
				// (set) Token: 0x06001C88 RID: 7304 RVA: 0x0000AE6F File Offset: 0x0000906F
				public unsafe int Depth
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.TestBuilder.AndNode.NativeFieldInfoPtr_Depth);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.TestBuilder.AndNode.NativeFieldInfoPtr_Depth)) = value;
					}
				}

				// Token: 0x17000732 RID: 1842
				// (get) Token: 0x06001C89 RID: 7305 RVA: 0x00086344 File Offset: 0x00084544
				// (set) Token: 0x06001C8A RID: 7306 RVA: 0x0000AE8A File Offset: 0x0000908A
				public unsafe Expression Node
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.TestBuilder.AndNode.NativeFieldInfoPtr_Node);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.TestBuilder.AndNode.NativeFieldInfoPtr_Node), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001338 RID: 4920
				private static readonly IntPtr NativeFieldInfoPtr_Depth;

				// Token: 0x04001339 RID: 4921
				private static readonly IntPtr NativeFieldInfoPtr_Node;
			}
		}

		// Token: 0x0200033E RID: 830
		public sealed class MergedRestriction : BindingRestrictions
		{
			// Token: 0x06001B84 RID: 7044 RVA: 0x00082814 File Offset: 0x00080A14
			// Note: this type is marked as 'beforefieldinit'.
			static MergedRestriction()
			{
				Il2CppClassPointerStore<BindingRestrictions.MergedRestriction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BindingRestrictions>.NativeClassPtr, "MergedRestriction");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingRestrictions.MergedRestriction>.NativeClassPtr);
				BindingRestrictions.MergedRestriction.NativeFieldInfoPtr_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingRestrictions.MergedRestriction>.NativeClassPtr, "Left");
				BindingRestrictions.MergedRestriction.NativeFieldInfoPtr_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingRestrictions.MergedRestriction>.NativeClassPtr, "Right");
				BindingRestrictions.MergedRestriction.NativeMethodInfoPtr__ctor_Internal_Void_BindingRestrictions_BindingRestrictions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions.MergedRestriction>.NativeClassPtr, 100666369);
				BindingRestrictions.MergedRestriction.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions.MergedRestriction>.NativeClassPtr, 100666370);
			}

			// Token: 0x06001B85 RID: 7045 RVA: 0x00082890 File Offset: 0x00080A90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028022, XrefRangeEnd = 1028028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MergedRestriction(BindingRestrictions left, BindingRestrictions right)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindingRestrictions.MergedRestriction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.MergedRestriction.NativeMethodInfoPtr__ctor_Internal_Void_BindingRestrictions_BindingRestrictions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B86 RID: 7046 RVA: 0x000828F0 File Offset: 0x00080AF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028028, XrefRangeEnd = 1028093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Expression GetExpression()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.MergedRestriction.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}

			// Token: 0x06001B87 RID: 7047 RVA: 0x0000A7AA File Offset: 0x000089AA
			public MergedRestriction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F2 RID: 1778
			// (get) Token: 0x06001B88 RID: 7048 RVA: 0x00082930 File Offset: 0x00080B30
			// (set) Token: 0x06001B89 RID: 7049 RVA: 0x0000A7B3 File Offset: 0x000089B3
			public unsafe BindingRestrictions Left
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.MergedRestriction.NativeFieldInfoPtr_Left);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BindingRestrictions>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.MergedRestriction.NativeFieldInfoPtr_Left), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006F3 RID: 1779
			// (get) Token: 0x06001B8A RID: 7050 RVA: 0x00082960 File Offset: 0x00080B60
			// (set) Token: 0x06001B8B RID: 7051 RVA: 0x0000A7D2 File Offset: 0x000089D2
			public unsafe BindingRestrictions Right
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.MergedRestriction.NativeFieldInfoPtr_Right);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BindingRestrictions>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.MergedRestriction.NativeFieldInfoPtr_Right), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001299 RID: 4761
			private static readonly IntPtr NativeFieldInfoPtr_Left;

			// Token: 0x0400129A RID: 4762
			private static readonly IntPtr NativeFieldInfoPtr_Right;

			// Token: 0x0400129B RID: 4763
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BindingRestrictions_BindingRestrictions_0;

			// Token: 0x0400129C RID: 4764
			private static readonly IntPtr NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_0;
		}

		// Token: 0x0200033F RID: 831
		public sealed class CustomRestriction : BindingRestrictions
		{
			// Token: 0x06001B8C RID: 7052 RVA: 0x00082990 File Offset: 0x00080B90
			// Note: this type is marked as 'beforefieldinit'.
			static CustomRestriction()
			{
				Il2CppClassPointerStore<BindingRestrictions.CustomRestriction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BindingRestrictions>.NativeClassPtr, "CustomRestriction");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingRestrictions.CustomRestriction>.NativeClassPtr);
				BindingRestrictions.CustomRestriction.NativeFieldInfoPtr__expression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingRestrictions.CustomRestriction>.NativeClassPtr, "_expression");
				BindingRestrictions.CustomRestriction.NativeMethodInfoPtr__ctor_Internal_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions.CustomRestriction>.NativeClassPtr, 100666371);
				BindingRestrictions.CustomRestriction.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions.CustomRestriction>.NativeClassPtr, 100666372);
				BindingRestrictions.CustomRestriction.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions.CustomRestriction>.NativeClassPtr, 100666373);
				BindingRestrictions.CustomRestriction.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions.CustomRestriction>.NativeClassPtr, 100666374);
			}

			// Token: 0x06001B8D RID: 7053 RVA: 0x00082A20 File Offset: 0x00080C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028093, XrefRangeEnd = 1028098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CustomRestriction(Expression expression)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindingRestrictions.CustomRestriction>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(expression);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.CustomRestriction.NativeMethodInfoPtr__ctor_Internal_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B8E RID: 7054 RVA: 0x00082A6C File Offset: 0x00080C6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028098, XrefRangeEnd = 1028100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.CustomRestriction.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B8F RID: 7055 RVA: 0x00082ABC File Offset: 0x00080CBC
			[CallerCount(0)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.CustomRestriction.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001B90 RID: 7056 RVA: 0x00082AF8 File Offset: 0x00080CF8
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Expression GetExpression()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.CustomRestriction.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}

			// Token: 0x06001B91 RID: 7057 RVA: 0x0000A7F1 File Offset: 0x000089F1
			public CustomRestriction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F4 RID: 1780
			// (get) Token: 0x06001B92 RID: 7058 RVA: 0x00082B38 File Offset: 0x00080D38
			// (set) Token: 0x06001B93 RID: 7059 RVA: 0x0000A7FA File Offset: 0x000089FA
			public unsafe Expression _expression
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.CustomRestriction.NativeFieldInfoPtr__expression);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.CustomRestriction.NativeFieldInfoPtr__expression), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400129D RID: 4765
			private static readonly IntPtr NativeFieldInfoPtr__expression;

			// Token: 0x0400129E RID: 4766
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Expression_0;

			// Token: 0x0400129F RID: 4767
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x040012A0 RID: 4768
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x040012A1 RID: 4769
			private static readonly IntPtr NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_0;
		}

		// Token: 0x02000340 RID: 832
		public sealed class TypeRestriction : BindingRestrictions
		{
			// Token: 0x06001B94 RID: 7060 RVA: 0x00082B68 File Offset: 0x00080D68
			// Note: this type is marked as 'beforefieldinit'.
			static TypeRestriction()
			{
				Il2CppClassPointerStore<BindingRestrictions.TypeRestriction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BindingRestrictions>.NativeClassPtr, "TypeRestriction");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingRestrictions.TypeRestriction>.NativeClassPtr);
				BindingRestrictions.TypeRestriction.NativeFieldInfoPtr__expression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingRestrictions.TypeRestriction>.NativeClassPtr, "_expression");
				BindingRestrictions.TypeRestriction.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingRestrictions.TypeRestriction>.NativeClassPtr, "_type");
				BindingRestrictions.TypeRestriction.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions.TypeRestriction>.NativeClassPtr, 100666375);
				BindingRestrictions.TypeRestriction.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions.TypeRestriction>.NativeClassPtr, 100666376);
				BindingRestrictions.TypeRestriction.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions.TypeRestriction>.NativeClassPtr, 100666377);
				BindingRestrictions.TypeRestriction.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions.TypeRestriction>.NativeClassPtr, 100666378);
			}

			// Token: 0x06001B95 RID: 7061 RVA: 0x00082C0C File Offset: 0x00080E0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028100, XrefRangeEnd = 1028106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TypeRestriction(Expression parameter, Type type)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindingRestrictions.TypeRestriction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameter);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.TypeRestriction.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B96 RID: 7062 RVA: 0x00082C6C File Offset: 0x00080E6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028106, XrefRangeEnd = 1028109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.TypeRestriction.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B97 RID: 7063 RVA: 0x00082CBC File Offset: 0x00080EBC
			[CallerCount(0)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.TypeRestriction.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001B98 RID: 7064 RVA: 0x00082CF8 File Offset: 0x00080EF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028109, XrefRangeEnd = 1028113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Expression GetExpression()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.TypeRestriction.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}

			// Token: 0x06001B99 RID: 7065 RVA: 0x0000A819 File Offset: 0x00008A19
			public TypeRestriction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F5 RID: 1781
			// (get) Token: 0x06001B9A RID: 7066 RVA: 0x00082D38 File Offset: 0x00080F38
			// (set) Token: 0x06001B9B RID: 7067 RVA: 0x0000A822 File Offset: 0x00008A22
			public unsafe Expression _expression
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.TypeRestriction.NativeFieldInfoPtr__expression);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.TypeRestriction.NativeFieldInfoPtr__expression), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006F6 RID: 1782
			// (get) Token: 0x06001B9C RID: 7068 RVA: 0x00082D68 File Offset: 0x00080F68
			// (set) Token: 0x06001B9D RID: 7069 RVA: 0x0000A841 File Offset: 0x00008A41
			public unsafe Type _type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.TypeRestriction.NativeFieldInfoPtr__type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.TypeRestriction.NativeFieldInfoPtr__type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012A2 RID: 4770
			private static readonly IntPtr NativeFieldInfoPtr__expression;

			// Token: 0x040012A3 RID: 4771
			private static readonly IntPtr NativeFieldInfoPtr__type;

			// Token: 0x040012A4 RID: 4772
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Expression_Type_0;

			// Token: 0x040012A5 RID: 4773
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x040012A6 RID: 4774
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x040012A7 RID: 4775
			private static readonly IntPtr NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_0;
		}

		// Token: 0x02000341 RID: 833
		public sealed class InstanceRestriction : BindingRestrictions
		{
			// Token: 0x06001B9E RID: 7070 RVA: 0x00082D98 File Offset: 0x00080F98
			// Note: this type is marked as 'beforefieldinit'.
			static InstanceRestriction()
			{
				Il2CppClassPointerStore<BindingRestrictions.InstanceRestriction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BindingRestrictions>.NativeClassPtr, "InstanceRestriction");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingRestrictions.InstanceRestriction>.NativeClassPtr);
				BindingRestrictions.InstanceRestriction.NativeFieldInfoPtr__expression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingRestrictions.InstanceRestriction>.NativeClassPtr, "_expression");
				BindingRestrictions.InstanceRestriction.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingRestrictions.InstanceRestriction>.NativeClassPtr, "_instance");
				BindingRestrictions.InstanceRestriction.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions.InstanceRestriction>.NativeClassPtr, 100666379);
				BindingRestrictions.InstanceRestriction.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions.InstanceRestriction>.NativeClassPtr, 100666380);
				BindingRestrictions.InstanceRestriction.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions.InstanceRestriction>.NativeClassPtr, 100666381);
				BindingRestrictions.InstanceRestriction.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingRestrictions.InstanceRestriction>.NativeClassPtr, 100666382);
			}

			// Token: 0x06001B9F RID: 7071 RVA: 0x00082E3C File Offset: 0x0008103C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028113, XrefRangeEnd = 1028119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InstanceRestriction(Expression parameter, Object instance)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindingRestrictions.InstanceRestriction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameter);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.InstanceRestriction.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BA0 RID: 7072 RVA: 0x00082E9C File Offset: 0x0008109C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028119, XrefRangeEnd = 1028121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.InstanceRestriction.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BA1 RID: 7073 RVA: 0x00082EEC File Offset: 0x000810EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028121, XrefRangeEnd = 1028122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.InstanceRestriction.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001BA2 RID: 7074 RVA: 0x00082F28 File Offset: 0x00081128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028122, XrefRangeEnd = 1028188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Expression GetExpression()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingRestrictions.InstanceRestriction.NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}

			// Token: 0x06001BA3 RID: 7075 RVA: 0x0000A860 File Offset: 0x00008A60
			public InstanceRestriction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F7 RID: 1783
			// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x00082F68 File Offset: 0x00081168
			// (set) Token: 0x06001BA5 RID: 7077 RVA: 0x0000A869 File Offset: 0x00008A69
			public unsafe Expression _expression
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.InstanceRestriction.NativeFieldInfoPtr__expression);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.InstanceRestriction.NativeFieldInfoPtr__expression), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006F8 RID: 1784
			// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x00082F98 File Offset: 0x00081198
			// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x0000A888 File Offset: 0x00008A88
			public unsafe Object _instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.InstanceRestriction.NativeFieldInfoPtr__instance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingRestrictions.InstanceRestriction.NativeFieldInfoPtr__instance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012A8 RID: 4776
			private static readonly IntPtr NativeFieldInfoPtr__expression;

			// Token: 0x040012A9 RID: 4777
			private static readonly IntPtr NativeFieldInfoPtr__instance;

			// Token: 0x040012AA RID: 4778
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Expression_Object_0;

			// Token: 0x040012AB RID: 4779
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x040012AC RID: 4780
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x040012AD RID: 4781
			private static readonly IntPtr NativeMethodInfoPtr_GetExpression_Internal_Virtual_Expression_0;
		}

		// Token: 0x02000342 RID: 834
		public sealed class BindingRestrictionsProxy : Object
		{
			// Token: 0x06001BA8 RID: 7080 RVA: 0x0000A8A7 File Offset: 0x00008AA7
			// Note: this type is marked as 'beforefieldinit'.
			static BindingRestrictionsProxy()
			{
				Il2CppClassPointerStore<BindingRestrictions.BindingRestrictionsProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BindingRestrictions>.NativeClassPtr, "BindingRestrictionsProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingRestrictions.BindingRestrictionsProxy>.NativeClassPtr);
			}

			// Token: 0x06001BA9 RID: 7081 RVA: 0x0000A8C7 File Offset: 0x00008AC7
			public BindingRestrictionsProxy(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
