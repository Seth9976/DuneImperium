using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Data
{
	// Token: 0x0200001C RID: 28
	public sealed class TypeLimiter : Object
	{
		// Token: 0x0600046F RID: 1135 RVA: 0x0001BC98 File Offset: 0x00019E98
		// Note: this type is marked as 'beforefieldinit'.
		static TypeLimiter()
		{
			Il2CppClassPointerStore<TypeLimiter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "TypeLimiter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeLimiter>.NativeClassPtr);
			TypeLimiter.NativeFieldInfoPtr_s_activeScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLimiter>.NativeClassPtr, "s_activeScope");
			TypeLimiter.NativeFieldInfoPtr_m_instanceScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLimiter>.NativeClassPtr, "m_instanceScope");
			TypeLimiter.NativeMethodInfoPtr__ctor_Private_Void_Scope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLimiter>.NativeClassPtr, 100664060);
			TypeLimiter.NativeMethodInfoPtr_get_IsTypeLimitingDisabled_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLimiter>.NativeClassPtr, 100664061);
			TypeLimiter.NativeMethodInfoPtr_Capture_Public_Static_TypeLimiter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLimiter>.NativeClassPtr, 100664062);
			TypeLimiter.NativeMethodInfoPtr_EnsureTypeIsAllowed_Public_Static_Void_Type_TypeLimiter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLimiter>.NativeClassPtr, 100664063);
			TypeLimiter.NativeMethodInfoPtr_EnterRestrictedScope_Public_Static_IDisposable_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLimiter>.NativeClassPtr, 100664064);
			TypeLimiter.NativeMethodInfoPtr_EnterRestrictedScope_Public_Static_IDisposable_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLimiter>.NativeClassPtr, 100664065);
			TypeLimiter.NativeMethodInfoPtr_GetPreviouslyDeclaredDataTypes_Private_Static_IEnumerable_1_Type_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLimiter>.NativeClassPtr, 100664066);
			TypeLimiter.NativeMethodInfoPtr_GetPreviouslyDeclaredDataTypes_Private_Static_IEnumerable_1_Type_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLimiter>.NativeClassPtr, 100664067);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0001BD90 File Offset: 0x00019F90
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeLimiter(TypeLimiter.Scope scope)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeLimiter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scope);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLimiter.NativeMethodInfoPtr__ctor_Private_Void_Scope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x0001BDDC File Offset: 0x00019FDC
		public unsafe static bool IsTypeLimitingDisabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897580, XrefRangeEnd = 897585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLimiter.NativeMethodInfoPtr_get_IsTypeLimitingDisabled_Private_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0001BE0C File Offset: 0x0001A00C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 897592, RefRangeEnd = 897593, XrefRangeStart = 897585, XrefRangeEnd = 897592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeLimiter Capture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLimiter.NativeMethodInfoPtr_Capture_Public_Static_TypeLimiter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeLimiter>(intPtr3) : null;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0001BE40 File Offset: 0x0001A040
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 897615, RefRangeEnd = 897618, XrefRangeStart = 897593, XrefRangeEnd = 897615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureTypeIsAllowed(Type type, TypeLimiter capturedLimiter = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capturedLimiter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLimiter.NativeMethodInfoPtr_EnsureTypeIsAllowed_Public_Static_Void_Type_TypeLimiter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0001BE88 File Offset: 0x0001A088
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 897625, RefRangeEnd = 897627, XrefRangeStart = 897618, XrefRangeEnd = 897625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IDisposable EnterRestrictedScope(DataSet dataSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLimiter.NativeMethodInfoPtr_EnterRestrictedScope_Public_Static_IDisposable_DataSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr3) : null;
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0001BECC File Offset: 0x0001A0CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 897634, RefRangeEnd = 897635, XrefRangeStart = 897627, XrefRangeEnd = 897634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IDisposable EnterRestrictedScope(DataTable dataTable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataTable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLimiter.NativeMethodInfoPtr_EnterRestrictedScope_Public_Static_IDisposable_DataTable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr3) : null;
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0001BF10 File Offset: 0x0001A110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 897659, RefRangeEnd = 897660, XrefRangeStart = 897635, XrefRangeEnd = 897659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataTable dataTable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataTable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLimiter.NativeMethodInfoPtr_GetPreviouslyDeclaredDataTypes_Private_Static_IEnumerable_1_Type_DataTable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0001BF54 File Offset: 0x0001A154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897660, XrefRangeEnd = 897684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataSet dataSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLimiter.NativeMethodInfoPtr_GetPreviouslyDeclaredDataTypes_Private_Static_IEnumerable_1_Type_DataSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x000033C2 File Offset: 0x000015C2
		public TypeLimiter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x0001BF98 File Offset: 0x0001A198
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x000033CB File Offset: 0x000015CB
		public unsafe static TypeLimiter.Scope s_activeScope
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeLimiter.NativeFieldInfoPtr_s_activeScope, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeLimiter.Scope>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeLimiter.NativeFieldInfoPtr_s_activeScope, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x0001BFC0 File Offset: 0x0001A1C0
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x000033DD File Offset: 0x000015DD
		public unsafe TypeLimiter.Scope m_instanceScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLimiter.NativeFieldInfoPtr_m_instanceScope);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeLimiter.Scope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLimiter.NativeFieldInfoPtr_m_instanceScope), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeFieldInfoPtr_s_activeScope;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeFieldInfoPtr_m_instanceScope;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Scope_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTypeLimitingDisabled_Private_Static_get_Boolean_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_Capture_Public_Static_TypeLimiter_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_EnsureTypeIsAllowed_Public_Static_Void_Type_TypeLimiter_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_EnterRestrictedScope_Public_Static_IDisposable_DataSet_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_EnterRestrictedScope_Public_Static_IDisposable_DataTable_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviouslyDeclaredDataTypes_Private_Static_IEnumerable_1_Type_DataTable_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviouslyDeclaredDataTypes_Private_Static_IEnumerable_1_Type_DataSet_0;

		// Token: 0x020000D0 RID: 208
		public sealed class Scope : Object
		{
			// Token: 0x06001449 RID: 5193 RVA: 0x00061298 File Offset: 0x0005F498
			// Note: this type is marked as 'beforefieldinit'.
			static Scope()
			{
				Il2CppClassPointerStore<TypeLimiter.Scope>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeLimiter>.NativeClassPtr, "Scope");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeLimiter.Scope>.NativeClassPtr);
				TypeLimiter.Scope.NativeFieldInfoPtr_s_allowedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLimiter.Scope>.NativeClassPtr, "s_allowedTypes");
				TypeLimiter.Scope.NativeFieldInfoPtr_m_allowedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLimiter.Scope>.NativeClassPtr, "m_allowedTypes");
				TypeLimiter.Scope.NativeFieldInfoPtr_m_previousScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLimiter.Scope>.NativeClassPtr, "m_previousScope");
				TypeLimiter.Scope.NativeMethodInfoPtr__ctor_Internal_Void_Scope_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLimiter.Scope>.NativeClassPtr, 100664068);
				TypeLimiter.Scope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLimiter.Scope>.NativeClassPtr, 100664069);
				TypeLimiter.Scope.NativeMethodInfoPtr_IsAllowedType_Public_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLimiter.Scope>.NativeClassPtr, 100664070);
				TypeLimiter.Scope.NativeMethodInfoPtr_IsTypeUnconditionallyAllowed_Private_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLimiter.Scope>.NativeClassPtr, 100664071);
			}

			// Token: 0x0600144A RID: 5194 RVA: 0x00061350 File Offset: 0x0005F550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897498, XrefRangeEnd = 897525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Scope(TypeLimiter.Scope previousScope, IEnumerable<Type> allowedTypes)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeLimiter.Scope>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousScope);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allowedTypes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLimiter.Scope.NativeMethodInfoPtr__ctor_Internal_Void_Scope_IEnumerable_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600144B RID: 5195 RVA: 0x000613B0 File Offset: 0x0005F5B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897525, XrefRangeEnd = 897541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLimiter.Scope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600144C RID: 5196 RVA: 0x000613E4 File Offset: 0x0005F5E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897541, XrefRangeEnd = 897561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsAllowedType(Type type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLimiter.Scope.NativeMethodInfoPtr_IsAllowedType_Public_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600144D RID: 5197 RVA: 0x00061434 File Offset: 0x0005F634
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 897577, RefRangeEnd = 897579, XrefRangeStart = 897561, XrefRangeEnd = 897577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsTypeUnconditionallyAllowed(Type type)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLimiter.Scope.NativeMethodInfoPtr_IsTypeUnconditionallyAllowed_Private_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600144E RID: 5198 RVA: 0x00007A36 File Offset: 0x00005C36
			public Scope(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000499 RID: 1177
			// (get) Token: 0x0600144F RID: 5199 RVA: 0x00061478 File Offset: 0x0005F678
			// (set) Token: 0x06001450 RID: 5200 RVA: 0x00007A3F File Offset: 0x00005C3F
			public unsafe static HashSet<Type> s_allowedTypes
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TypeLimiter.Scope.NativeFieldInfoPtr_s_allowedTypes, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Type>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TypeLimiter.Scope.NativeFieldInfoPtr_s_allowedTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700049A RID: 1178
			// (get) Token: 0x06001451 RID: 5201 RVA: 0x000614A0 File Offset: 0x0005F6A0
			// (set) Token: 0x06001452 RID: 5202 RVA: 0x00007A51 File Offset: 0x00005C51
			public unsafe HashSet<Type> m_allowedTypes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLimiter.Scope.NativeFieldInfoPtr_m_allowedTypes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Type>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLimiter.Scope.NativeFieldInfoPtr_m_allowedTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700049B RID: 1179
			// (get) Token: 0x06001453 RID: 5203 RVA: 0x000614D0 File Offset: 0x0005F6D0
			// (set) Token: 0x06001454 RID: 5204 RVA: 0x00007A70 File Offset: 0x00005C70
			public unsafe TypeLimiter.Scope m_previousScope
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLimiter.Scope.NativeFieldInfoPtr_m_previousScope);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeLimiter.Scope>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLimiter.Scope.NativeFieldInfoPtr_m_previousScope), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010E5 RID: 4325
			private static readonly IntPtr NativeFieldInfoPtr_s_allowedTypes;

			// Token: 0x040010E6 RID: 4326
			private static readonly IntPtr NativeFieldInfoPtr_m_allowedTypes;

			// Token: 0x040010E7 RID: 4327
			private static readonly IntPtr NativeFieldInfoPtr_m_previousScope;

			// Token: 0x040010E8 RID: 4328
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Scope_IEnumerable_1_Type_0;

			// Token: 0x040010E9 RID: 4329
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040010EA RID: 4330
			private static readonly IntPtr NativeMethodInfoPtr_IsAllowedType_Public_Boolean_Type_0;

			// Token: 0x040010EB RID: 4331
			private static readonly IntPtr NativeMethodInfoPtr_IsTypeUnconditionallyAllowed_Private_Static_Boolean_Type_0;

			// Token: 0x020000FD RID: 253
			[ObfuscatedName("System.Data.TypeLimiter+Scope+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x06001558 RID: 5464 RVA: 0x00064B5C File Offset: 0x00062D5C
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<TypeLimiter.Scope.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeLimiter.Scope>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeLimiter.Scope.__c>.NativeClassPtr);
					TypeLimiter.Scope.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLimiter.Scope.__c>.NativeClassPtr, "<>9");
					TypeLimiter.Scope.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLimiter.Scope.__c>.NativeClassPtr, "<>9__3_0");
					TypeLimiter.Scope.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLimiter.Scope.__c>.NativeClassPtr, 100664074);
					TypeLimiter.Scope.__c.NativeMethodInfoPtr___ctor_b__3_0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLimiter.Scope.__c>.NativeClassPtr, 100664075);
				}

				// Token: 0x06001559 RID: 5465 RVA: 0x00064BD8 File Offset: 0x00062DD8
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeLimiter.Scope.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLimiter.Scope.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600155A RID: 5466 RVA: 0x00064C14 File Offset: 0x00062E14
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897478, XrefRangeEnd = 897498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool __ctor_b__3_0(Type type)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLimiter.Scope.__c.NativeMethodInfoPtr___ctor_b__3_0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x0600155B RID: 5467 RVA: 0x00008263 File Offset: 0x00006463
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170004DE RID: 1246
				// (get) Token: 0x0600155C RID: 5468 RVA: 0x00064C64 File Offset: 0x00062E64
				// (set) Token: 0x0600155D RID: 5469 RVA: 0x0000826C File Offset: 0x0000646C
				public unsafe static TypeLimiter.Scope.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(TypeLimiter.Scope.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeLimiter.Scope.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(TypeLimiter.Scope.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170004DF RID: 1247
				// (get) Token: 0x0600155E RID: 5470 RVA: 0x00064C8C File Offset: 0x00062E8C
				// (set) Token: 0x0600155F RID: 5471 RVA: 0x0000827E File Offset: 0x0000647E
				public unsafe static Func<Type, bool> __9__3_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(TypeLimiter.Scope.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(TypeLimiter.Scope.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040011A2 RID: 4514
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x040011A3 RID: 4515
				private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

				// Token: 0x040011A4 RID: 4516
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040011A5 RID: 4517
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__3_0_Internal_Boolean_Type_0;
			}
		}

		// Token: 0x020000D1 RID: 209
		[ObfuscatedName("System.Data.TypeLimiter+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001455 RID: 5205 RVA: 0x00061500 File Offset: 0x0005F700
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TypeLimiter.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeLimiter>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeLimiter.__c>.NativeClassPtr);
				TypeLimiter.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLimiter.__c>.NativeClassPtr, "<>9");
				TypeLimiter.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLimiter.__c>.NativeClassPtr, "<>9__10_0");
				TypeLimiter.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLimiter.__c>.NativeClassPtr, "<>9__11_0");
				TypeLimiter.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLimiter.__c>.NativeClassPtr, 100664077);
				TypeLimiter.__c.NativeMethodInfoPtr__GetPreviouslyDeclaredDataTypes_b__10_0_Internal_Type_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLimiter.__c>.NativeClassPtr, 100664078);
				TypeLimiter.__c.NativeMethodInfoPtr__GetPreviouslyDeclaredDataTypes_b__11_0_Internal_IEnumerable_1_Type_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLimiter.__c>.NativeClassPtr, 100664079);
			}

			// Token: 0x06001456 RID: 5206 RVA: 0x000615A4 File Offset: 0x0005F7A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeLimiter.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLimiter.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001457 RID: 5207 RVA: 0x000615E0 File Offset: 0x0005F7E0
			[CallerCount(0)]
			public unsafe Type _GetPreviouslyDeclaredDataTypes_b__10_0(DataColumn column)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLimiter.__c.NativeMethodInfoPtr__GetPreviouslyDeclaredDataTypes_b__10_0_Internal_Type_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x06001458 RID: 5208 RVA: 0x00061630 File Offset: 0x0005F830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897579, XrefRangeEnd = 897580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Type> _GetPreviouslyDeclaredDataTypes_b__11_0(DataTable table)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLimiter.__c.NativeMethodInfoPtr__GetPreviouslyDeclaredDataTypes_b__11_0_Internal_IEnumerable_1_Type_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
				}
			}

			// Token: 0x06001459 RID: 5209 RVA: 0x00007A8F File Offset: 0x00005C8F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700049C RID: 1180
			// (get) Token: 0x0600145A RID: 5210 RVA: 0x00061680 File Offset: 0x0005F880
			// (set) Token: 0x0600145B RID: 5211 RVA: 0x00007A98 File Offset: 0x00005C98
			public unsafe static TypeLimiter.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TypeLimiter.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeLimiter.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TypeLimiter.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700049D RID: 1181
			// (get) Token: 0x0600145C RID: 5212 RVA: 0x000616A8 File Offset: 0x0005F8A8
			// (set) Token: 0x0600145D RID: 5213 RVA: 0x00007AAA File Offset: 0x00005CAA
			public unsafe static Func<DataColumn, Type> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TypeLimiter.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataColumn, Type>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TypeLimiter.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700049E RID: 1182
			// (get) Token: 0x0600145E RID: 5214 RVA: 0x000616D0 File Offset: 0x0005F8D0
			// (set) Token: 0x0600145F RID: 5215 RVA: 0x00007ABC File Offset: 0x00005CBC
			public unsafe static Func<DataTable, IEnumerable<Type>> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TypeLimiter.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataTable, IEnumerable<Type>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TypeLimiter.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010EC RID: 4332
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040010ED RID: 4333
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x040010EE RID: 4334
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x040010EF RID: 4335
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040010F0 RID: 4336
			private static readonly IntPtr NativeMethodInfoPtr__GetPreviouslyDeclaredDataTypes_b__10_0_Internal_Type_DataColumn_0;

			// Token: 0x040010F1 RID: 4337
			private static readonly IntPtr NativeMethodInfoPtr__GetPreviouslyDeclaredDataTypes_b__11_0_Internal_IEnumerable_1_Type_DataTable_0;
		}
	}
}
