using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Reflection;

namespace Canis.json
{
	// Token: 0x0200000C RID: 12
	public sealed class TypedIDAnalyzer : DwdTypeAnalyzer
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00003CF0 File Offset: 0x00001EF0
		// Note: this type is marked as 'beforefieldinit'.
		static TypedIDAnalyzer()
		{
			Il2CppClassPointerStore<TypedIDAnalyzer>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json", "TypedIDAnalyzer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypedIDAnalyzer>.NativeClassPtr);
			TypedIDAnalyzer.NativeFieldInfoPtr_createFunctions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedIDAnalyzer>.NativeClassPtr, "createFunctions");
			TypedIDAnalyzer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedIDAnalyzer>.NativeClassPtr, 100663331);
			TypedIDAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedIDAnalyzer>.NativeClassPtr, 100663332);
			TypedIDAnalyzer.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedIDAnalyzer>.NativeClassPtr, 100663333);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003D70 File Offset: 0x00001F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248421, XrefRangeEnd = 1248438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypedIDAnalyzer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypedIDAnalyzer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedIDAnalyzer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003DAC File Offset: 0x00001FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248438, XrefRangeEnd = 1248441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Analyze(DwdModelAnalyzer analyzer, MorePeekableStream tokens, Type targetType, out Object result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(analyzer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TypedIDAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003E44 File Offset: 0x00002044
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1248499, RefRangeEnd = 1248501, XrefRangeStart = 1248441, XrefRangeEnd = 1248499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedID CreateID(string guid, Type targetType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedIDAnalyzer.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypedID>(intPtr3) : null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002295 File Offset: 0x00000495
		public TypedIDAnalyzer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00003E9C File Offset: 0x0000209C
		// (set) Token: 0x06000063 RID: 99 RVA: 0x0000229E File Offset: 0x0000049E
		public unsafe static ConcurrentDictionary<Type, TypedIDAnalyzer.CreateIDMethod> createFunctions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypedIDAnalyzer.NativeFieldInfoPtr_createFunctions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Type, TypedIDAnalyzer.CreateIDMethod>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypedIDAnalyzer.NativeFieldInfoPtr_createFunctions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_createFunctions;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_Type_0;

		// Token: 0x02000024 RID: 36
		public sealed class CreateIDMethod : MulticastDelegate
		{
			// Token: 0x06000121 RID: 289 RVA: 0x00006788 File Offset: 0x00004988
			// Note: this type is marked as 'beforefieldinit'.
			static CreateIDMethod()
			{
				Il2CppClassPointerStore<TypedIDAnalyzer.CreateIDMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypedIDAnalyzer>.NativeClassPtr, "CreateIDMethod");
				TypedIDAnalyzer.CreateIDMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedIDAnalyzer.CreateIDMethod>.NativeClassPtr, 100663335);
				TypedIDAnalyzer.CreateIDMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TypedID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedIDAnalyzer.CreateIDMethod>.NativeClassPtr, 100663336);
				TypedIDAnalyzer.CreateIDMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedIDAnalyzer.CreateIDMethod>.NativeClassPtr, 100663337);
				TypedIDAnalyzer.CreateIDMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TypedID_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedIDAnalyzer.CreateIDMethod>.NativeClassPtr, 100663338);
			}

			// Token: 0x06000122 RID: 290 RVA: 0x000067FC File Offset: 0x000049FC
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 427006, RefRangeEnd = 427011, XrefRangeStart = 427006, XrefRangeEnd = 427011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CreateIDMethod(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypedIDAnalyzer.CreateIDMethod>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedIDAnalyzer.CreateIDMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000123 RID: 291 RVA: 0x00006858 File Offset: 0x00004A58
			[CallerCount(0)]
			public unsafe TypedID Invoke(string guid)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedIDAnalyzer.CreateIDMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TypedID_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypedID>(intPtr3) : null;
				}
			}

			// Token: 0x06000124 RID: 292 RVA: 0x000068A8 File Offset: 0x00004AA8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string guid, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedIDAnalyzer.CreateIDMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000125 RID: 293 RVA: 0x0000691C File Offset: 0x00004B1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TypedID EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedIDAnalyzer.CreateIDMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TypedID_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypedID>(intPtr3) : null;
				}
			}

			// Token: 0x06000126 RID: 294 RVA: 0x00002774 File Offset: 0x00000974
			public CreateIDMethod(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000127 RID: 295 RVA: 0x0000277D File Offset: 0x0000097D
			public static implicit operator TypedIDAnalyzer.CreateIDMethod(Func<string, TypedID> A_0)
			{
				return DelegateSupport.ConvertDelegate<TypedIDAnalyzer.CreateIDMethod>(A_0);
			}

			// Token: 0x06000128 RID: 296 RVA: 0x00002785 File Offset: 0x00000985
			public static TypedIDAnalyzer.CreateIDMethod operator +(TypedIDAnalyzer.CreateIDMethod A_0, TypedIDAnalyzer.CreateIDMethod A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<TypedIDAnalyzer.CreateIDMethod>();
			}

			// Token: 0x06000129 RID: 297 RVA: 0x00002793 File Offset: 0x00000993
			public static TypedIDAnalyzer.CreateIDMethod operator -(TypedIDAnalyzer.CreateIDMethod A_0, TypedIDAnalyzer.CreateIDMethod A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<TypedIDAnalyzer.CreateIDMethod>();
				}
				return delegate2;
			}

			// Token: 0x040000A6 RID: 166
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040000A7 RID: 167
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TypedID_String_0;

			// Token: 0x040000A8 RID: 168
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

			// Token: 0x040000A9 RID: 169
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TypedID_IAsyncResult_0;
		}

		// Token: 0x02000025 RID: 37
		[ObfuscatedName("Canis.json.TypedIDAnalyzer+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600012A RID: 298 RVA: 0x0000696C File Offset: 0x00004B6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<TypedIDAnalyzer.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypedIDAnalyzer>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypedIDAnalyzer.__c__DisplayClass4_0>.NativeClassPtr);
				TypedIDAnalyzer.__c__DisplayClass4_0.NativeFieldInfoPtr_stringCtor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedIDAnalyzer.__c__DisplayClass4_0>.NativeClassPtr, "stringCtor");
				TypedIDAnalyzer.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedIDAnalyzer.__c__DisplayClass4_0>.NativeClassPtr, 100663339);
				TypedIDAnalyzer.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateID_b__0_Internal_TypedID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedIDAnalyzer.__c__DisplayClass4_0>.NativeClassPtr, 100663340);
			}

			// Token: 0x0600012B RID: 299 RVA: 0x000069D4 File Offset: 0x00004BD4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypedIDAnalyzer.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedIDAnalyzer.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600012C RID: 300 RVA: 0x00006A10 File Offset: 0x00004C10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248412, XrefRangeEnd = 1248421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TypedID _CreateID_b__0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedIDAnalyzer.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateID_b__0_Internal_TypedID_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypedID>(intPtr3) : null;
				}
			}

			// Token: 0x0600012D RID: 301 RVA: 0x000027A4 File Offset: 0x000009A4
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x0600012E RID: 302 RVA: 0x00006A60 File Offset: 0x00004C60
			// (set) Token: 0x0600012F RID: 303 RVA: 0x000027AD File Offset: 0x000009AD
			public unsafe ConstructorInfo stringCtor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedIDAnalyzer.__c__DisplayClass4_0.NativeFieldInfoPtr_stringCtor);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedIDAnalyzer.__c__DisplayClass4_0.NativeFieldInfoPtr_stringCtor), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000AA RID: 170
			private static readonly IntPtr NativeFieldInfoPtr_stringCtor;

			// Token: 0x040000AB RID: 171
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000AC RID: 172
			private static readonly IntPtr NativeMethodInfoPtr__CreateID_b__0_Internal_TypedID_String_0;
		}
	}
}
