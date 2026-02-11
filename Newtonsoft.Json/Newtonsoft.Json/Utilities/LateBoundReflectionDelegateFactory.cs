using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200005F RID: 95
	public class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory
	{
		// Token: 0x06000895 RID: 2197 RVA: 0x00039F08 File Offset: 0x00038108
		// Note: this type is marked as 'beforefieldinit'.
		static LateBoundReflectionDelegateFactory()
		{
			Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "LateBoundReflectionDelegateFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr);
			LateBoundReflectionDelegateFactory.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr, "_instance");
			LateBoundReflectionDelegateFactory.NativeMethodInfoPtr_get_Instance_Internal_Static_get_ReflectionDelegateFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr, 100664926);
			LateBoundReflectionDelegateFactory.NativeMethodInfoPtr_CreateParameterizedConstructor_Public_Virtual_ObjectConstructor_1_Object_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr, 100664927);
			LateBoundReflectionDelegateFactory.NativeMethodInfoPtr_CreateMethodCall_Public_Virtual_MethodCall_2_T_Object_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr, 100664928);
			LateBoundReflectionDelegateFactory.NativeMethodInfoPtr_CreateDefaultConstructor_Public_Virtual_Func_1_T_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr, 100664929);
			LateBoundReflectionDelegateFactory.NativeMethodInfoPtr_CreateGet_Public_Virtual_Func_2_T_Object_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr, 100664930);
			LateBoundReflectionDelegateFactory.NativeMethodInfoPtr_CreateGet_Public_Virtual_Func_2_T_Object_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr, 100664931);
			LateBoundReflectionDelegateFactory.NativeMethodInfoPtr_CreateSet_Public_Virtual_Action_2_T_Object_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr, 100664932);
			LateBoundReflectionDelegateFactory.NativeMethodInfoPtr_CreateSet_Public_Virtual_Action_2_T_Object_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr, 100664933);
			LateBoundReflectionDelegateFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr, 100664934);
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x0003A000 File Offset: 0x00038200
		public unsafe static ReflectionDelegateFactory Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744485, XrefRangeEnd = 744489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LateBoundReflectionDelegateFactory.NativeMethodInfoPtr_get_Instance_Internal_Static_get_ReflectionDelegateFactory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReflectionDelegateFactory>(intPtr3) : null;
			}
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0003A034 File Offset: 0x00038234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744489, XrefRangeEnd = 744511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ObjectConstructor<Object> CreateParameterizedConstructor(MethodBase method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LateBoundReflectionDelegateFactory.NativeMethodInfoPtr_CreateParameterizedConstructor_Public_Virtual_ObjectConstructor_1_Object_MethodBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0003A090 File Offset: 0x00038290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744511, XrefRangeEnd = 744532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodCall<T, Object> CreateMethodCall<T>(MethodBase method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LateBoundReflectionDelegateFactory.MethodInfoStoreGeneric_CreateMethodCall_Public_Virtual_MethodCall_2_T_Object_MethodBase_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodCall<T, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0003A0EC File Offset: 0x000382EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744532, XrefRangeEnd = 744556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Func<T> CreateDefaultConstructor<T>(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LateBoundReflectionDelegateFactory.MethodInfoStoreGeneric_CreateDefaultConstructor_Public_Virtual_Func_1_T_Type_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr3) : null;
			}
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0003A148 File Offset: 0x00038348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744556, XrefRangeEnd = 744567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Func<T, Object> CreateGet<T>(PropertyInfo propertyInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LateBoundReflectionDelegateFactory.MethodInfoStoreGeneric_CreateGet_Public_Virtual_Func_2_T_Object_PropertyInfo_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<T, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0003A1A4 File Offset: 0x000383A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744567, XrefRangeEnd = 744578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Func<T, Object> CreateGet<T>(FieldInfo fieldInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fieldInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LateBoundReflectionDelegateFactory.MethodInfoStoreGeneric_CreateGet_Public_Virtual_Func_2_T_Object_FieldInfo_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<T, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0003A200 File Offset: 0x00038400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744578, XrefRangeEnd = 744589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action<T, Object> CreateSet<T>(FieldInfo fieldInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fieldInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LateBoundReflectionDelegateFactory.MethodInfoStoreGeneric_CreateSet_Public_Virtual_Action_2_T_Object_FieldInfo_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<T, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0003A25C File Offset: 0x0003845C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744589, XrefRangeEnd = 744600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action<T, Object> CreateSet<T>(PropertyInfo propertyInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LateBoundReflectionDelegateFactory.MethodInfoStoreGeneric_CreateSet_Public_Virtual_Action_2_T_Object_PropertyInfo_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<T, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0003A2B8 File Offset: 0x000384B8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LateBoundReflectionDelegateFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LateBoundReflectionDelegateFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00004B9C File Offset: 0x00002D9C
		public LateBoundReflectionDelegateFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x0003A2F4 File Offset: 0x000384F4
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x00004BA5 File Offset: 0x00002DA5
		public unsafe static LateBoundReflectionDelegateFactory _instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LateBoundReflectionDelegateFactory.NativeFieldInfoPtr__instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LateBoundReflectionDelegateFactory>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LateBoundReflectionDelegateFactory.NativeFieldInfoPtr__instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeFieldInfoPtr__instance;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Internal_Static_get_ReflectionDelegateFactory_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_CreateParameterizedConstructor_Public_Virtual_ObjectConstructor_1_Object_MethodBase_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr_CreateMethodCall_Public_Virtual_MethodCall_2_T_Object_MethodBase_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultConstructor_Public_Virtual_Func_1_T_Type_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_CreateGet_Public_Virtual_Func_2_T_Object_PropertyInfo_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_CreateGet_Public_Virtual_Func_2_T_Object_FieldInfo_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_CreateSet_Public_Virtual_Action_2_T_Object_FieldInfo_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_CreateSet_Public_Virtual_Action_2_T_Object_PropertyInfo_0;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200019F RID: 415
		[ObfuscatedName("Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06001DA1 RID: 7585 RVA: 0x00089AE0 File Offset: 0x00087CE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass3_0>.NativeClassPtr);
				LateBoundReflectionDelegateFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass3_0>.NativeClassPtr, "c");
				LateBoundReflectionDelegateFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass3_0>.NativeClassPtr, "method");
				LateBoundReflectionDelegateFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass3_0>.NativeClassPtr, 100664936);
				LateBoundReflectionDelegateFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__CreateParameterizedConstructor_b__0_Internal_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass3_0>.NativeClassPtr, 100664937);
				LateBoundReflectionDelegateFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__CreateParameterizedConstructor_b__1_Internal_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass3_0>.NativeClassPtr, 100664938);
			}

			// Token: 0x06001DA2 RID: 7586 RVA: 0x00089B70 File Offset: 0x00087D70
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LateBoundReflectionDelegateFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DA3 RID: 7587 RVA: 0x00089BAC File Offset: 0x00087DAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744455, XrefRangeEnd = 744457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _CreateParameterizedConstructor_b__0(Il2CppReferenceArray<Object> a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LateBoundReflectionDelegateFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__CreateParameterizedConstructor_b__0_Internal_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001DA4 RID: 7588 RVA: 0x00089BFC File Offset: 0x00087DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744457, XrefRangeEnd = 744459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _CreateParameterizedConstructor_b__1(Il2CppReferenceArray<Object> a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LateBoundReflectionDelegateFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__CreateParameterizedConstructor_b__1_Internal_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001DA5 RID: 7589 RVA: 0x0000EB60 File Offset: 0x0000CD60
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000863 RID: 2147
			// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x00089C4C File Offset: 0x00087E4C
			// (set) Token: 0x06001DA7 RID: 7591 RVA: 0x0000EB69 File Offset: 0x0000CD69
			public unsafe ConstructorInfo c
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_c);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_c), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000864 RID: 2148
			// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x00089C7C File Offset: 0x00087E7C
			// (set) Token: 0x06001DA9 RID: 7593 RVA: 0x0000EB88 File Offset: 0x0000CD88
			public unsafe MethodBase method
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_method);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_method), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015C1 RID: 5569
			private static readonly IntPtr NativeFieldInfoPtr_c;

			// Token: 0x040015C2 RID: 5570
			private static readonly IntPtr NativeFieldInfoPtr_method;

			// Token: 0x040015C3 RID: 5571
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015C4 RID: 5572
			private static readonly IntPtr NativeMethodInfoPtr__CreateParameterizedConstructor_b__0_Internal_Object_Il2CppReferenceArray_1_Object_0;

			// Token: 0x040015C5 RID: 5573
			private static readonly IntPtr NativeMethodInfoPtr__CreateParameterizedConstructor_b__1_Internal_Object_Il2CppReferenceArray_1_Object_0;
		}

		// Token: 0x020001A0 RID: 416
		[ObfuscatedName("Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory+<>c__DisplayClass4_0`1")]
		public sealed class __c__DisplayClass4_0<T> : Object
		{
			// Token: 0x06001DAA RID: 7594 RVA: 0x00089CAC File Offset: 0x00087EAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr, "<>c__DisplayClass4_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>>.NativeClassPtr);
				LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>>.NativeClassPtr, "c");
				LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>>.NativeClassPtr, "method");
				LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>>.NativeClassPtr, 100664939);
				LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>.NativeMethodInfoPtr__CreateMethodCall_b__0_Internal_Object_T_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>>.NativeClassPtr, 100664940);
				LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>.NativeMethodInfoPtr__CreateMethodCall_b__1_Internal_Object_T_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>>.NativeClassPtr, 100664941);
			}

			// Token: 0x06001DAB RID: 7595 RVA: 0x00089D78 File Offset: 0x00087F78
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DAC RID: 7596 RVA: 0x00089DB4 File Offset: 0x00087FB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744459, XrefRangeEnd = 744461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _CreateMethodCall_b__0(T o, Il2CppReferenceArray<Object> a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = o;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref o;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>.NativeMethodInfoPtr__CreateMethodCall_b__0_Internal_Object_T_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<Object>(intPtr4) : null;
			}

			// Token: 0x06001DAD RID: 7597 RVA: 0x00089E4C File Offset: 0x0008804C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744461, XrefRangeEnd = 744467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _CreateMethodCall_b__1(T o, Il2CppReferenceArray<Object> a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = o;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref o;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>.NativeMethodInfoPtr__CreateMethodCall_b__1_Internal_Object_T_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<Object>(intPtr4) : null;
			}

			// Token: 0x06001DAE RID: 7598 RVA: 0x0000EBA7 File Offset: 0x0000CDA7
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000865 RID: 2149
			// (get) Token: 0x06001DAF RID: 7599 RVA: 0x00089EE4 File Offset: 0x000880E4
			// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
			public unsafe ConstructorInfo c
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>.NativeFieldInfoPtr_c);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>.NativeFieldInfoPtr_c), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000866 RID: 2150
			// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x00089F14 File Offset: 0x00088114
			// (set) Token: 0x06001DB2 RID: 7602 RVA: 0x0000EBCF File Offset: 0x0000CDCF
			public unsafe MethodBase method
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>.NativeFieldInfoPtr_method);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass4_0<T>.NativeFieldInfoPtr_method), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015C6 RID: 5574
			private static readonly IntPtr NativeFieldInfoPtr_c;

			// Token: 0x040015C7 RID: 5575
			private static readonly IntPtr NativeFieldInfoPtr_method;

			// Token: 0x040015C8 RID: 5576
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015C9 RID: 5577
			private static readonly IntPtr NativeMethodInfoPtr__CreateMethodCall_b__0_Internal_Object_T_Il2CppReferenceArray_1_Object_0;

			// Token: 0x040015CA RID: 5578
			private static readonly IntPtr NativeMethodInfoPtr__CreateMethodCall_b__1_Internal_Object_T_Il2CppReferenceArray_1_Object_0;
		}

		// Token: 0x020001A1 RID: 417
		[ObfuscatedName("Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory+<>c__DisplayClass5_0`1")]
		public sealed class __c__DisplayClass5_0<T> : Object
		{
			// Token: 0x06001DB3 RID: 7603 RVA: 0x00089F44 File Offset: 0x00088144
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr, "<>c__DisplayClass5_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>>.NativeClassPtr);
				LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>>.NativeClassPtr, "type");
				LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>.NativeFieldInfoPtr_constructorInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>>.NativeClassPtr, "constructorInfo");
				LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>>.NativeClassPtr, 100664942);
				LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>.NativeMethodInfoPtr__CreateDefaultConstructor_b__0_Internal_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>>.NativeClassPtr, 100664943);
				LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>.NativeMethodInfoPtr__CreateDefaultConstructor_b__1_Internal_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>>.NativeClassPtr, 100664944);
			}

			// Token: 0x06001DB4 RID: 7604 RVA: 0x0008A010 File Offset: 0x00088210
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DB5 RID: 7605 RVA: 0x0008A04C File Offset: 0x0008824C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744467, XrefRangeEnd = 744469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _CreateDefaultConstructor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>.NativeMethodInfoPtr__CreateDefaultConstructor_b__0_Internal_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x06001DB6 RID: 7606 RVA: 0x0008A088 File Offset: 0x00088288
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744469, XrefRangeEnd = 744471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _CreateDefaultConstructor_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>.NativeMethodInfoPtr__CreateDefaultConstructor_b__1_Internal_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x06001DB7 RID: 7607 RVA: 0x0000EBEE File Offset: 0x0000CDEE
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000867 RID: 2151
			// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x0008A0C4 File Offset: 0x000882C4
			// (set) Token: 0x06001DB9 RID: 7609 RVA: 0x0000EBF7 File Offset: 0x0000CDF7
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000868 RID: 2152
			// (get) Token: 0x06001DBA RID: 7610 RVA: 0x0008A0F4 File Offset: 0x000882F4
			// (set) Token: 0x06001DBB RID: 7611 RVA: 0x0000EC16 File Offset: 0x0000CE16
			public unsafe ConstructorInfo constructorInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>.NativeFieldInfoPtr_constructorInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass5_0<T>.NativeFieldInfoPtr_constructorInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015CB RID: 5579
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x040015CC RID: 5580
			private static readonly IntPtr NativeFieldInfoPtr_constructorInfo;

			// Token: 0x040015CD RID: 5581
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015CE RID: 5582
			private static readonly IntPtr NativeMethodInfoPtr__CreateDefaultConstructor_b__0_Internal_T_0;

			// Token: 0x040015CF RID: 5583
			private static readonly IntPtr NativeMethodInfoPtr__CreateDefaultConstructor_b__1_Internal_T_0;
		}

		// Token: 0x020001A2 RID: 418
		[ObfuscatedName("Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory+<>c__DisplayClass6_0`1")]
		public sealed class __c__DisplayClass6_0<T> : Object
		{
			// Token: 0x06001DBC RID: 7612 RVA: 0x0008A124 File Offset: 0x00088324
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass6_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr, "<>c__DisplayClass6_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass6_0<T>>.NativeClassPtr);
				LateBoundReflectionDelegateFactory.__c__DisplayClass6_0<T>.NativeFieldInfoPtr_propertyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass6_0<T>>.NativeClassPtr, "propertyInfo");
				LateBoundReflectionDelegateFactory.__c__DisplayClass6_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass6_0<T>>.NativeClassPtr, 100664945);
				LateBoundReflectionDelegateFactory.__c__DisplayClass6_0<T>.NativeMethodInfoPtr__CreateGet_b__0_Internal_Object_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass6_0<T>>.NativeClassPtr, 100664946);
			}

			// Token: 0x06001DBD RID: 7613 RVA: 0x0008A1C8 File Offset: 0x000883C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass6_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LateBoundReflectionDelegateFactory.__c__DisplayClass6_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DBE RID: 7614 RVA: 0x0008A204 File Offset: 0x00088404
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744471, XrefRangeEnd = 744475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _CreateGet_b__0(T o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = o;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref o;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LateBoundReflectionDelegateFactory.__c__DisplayClass6_0<T>.NativeMethodInfoPtr__CreateGet_b__0_Internal_Object_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<Object>(intPtr4) : null;
				}
			}

			// Token: 0x06001DBF RID: 7615 RVA: 0x0000EC35 File Offset: 0x0000CE35
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000869 RID: 2153
			// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x0008A28C File Offset: 0x0008848C
			// (set) Token: 0x06001DC1 RID: 7617 RVA: 0x0000EC3E File Offset: 0x0000CE3E
			public unsafe PropertyInfo propertyInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass6_0<T>.NativeFieldInfoPtr_propertyInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass6_0<T>.NativeFieldInfoPtr_propertyInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015D0 RID: 5584
			private static readonly IntPtr NativeFieldInfoPtr_propertyInfo;

			// Token: 0x040015D1 RID: 5585
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015D2 RID: 5586
			private static readonly IntPtr NativeMethodInfoPtr__CreateGet_b__0_Internal_Object_T_0;
		}

		// Token: 0x020001A3 RID: 419
		[ObfuscatedName("Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory+<>c__DisplayClass7_0`1")]
		public sealed class __c__DisplayClass7_0<T> : Object
		{
			// Token: 0x06001DC2 RID: 7618 RVA: 0x0008A2BC File Offset: 0x000884BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass7_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr, "<>c__DisplayClass7_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass7_0<T>>.NativeClassPtr);
				LateBoundReflectionDelegateFactory.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_fieldInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass7_0<T>>.NativeClassPtr, "fieldInfo");
				LateBoundReflectionDelegateFactory.__c__DisplayClass7_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass7_0<T>>.NativeClassPtr, 100664947);
				LateBoundReflectionDelegateFactory.__c__DisplayClass7_0<T>.NativeMethodInfoPtr__CreateGet_b__0_Internal_Object_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass7_0<T>>.NativeClassPtr, 100664948);
			}

			// Token: 0x06001DC3 RID: 7619 RVA: 0x0008A360 File Offset: 0x00088560
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass7_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LateBoundReflectionDelegateFactory.__c__DisplayClass7_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DC4 RID: 7620 RVA: 0x0008A39C File Offset: 0x0008859C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744475, XrefRangeEnd = 744479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _CreateGet_b__0(T o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = o;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref o;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LateBoundReflectionDelegateFactory.__c__DisplayClass7_0<T>.NativeMethodInfoPtr__CreateGet_b__0_Internal_Object_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<Object>(intPtr4) : null;
				}
			}

			// Token: 0x06001DC5 RID: 7621 RVA: 0x0000EC5D File Offset: 0x0000CE5D
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700086A RID: 2154
			// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x0008A424 File Offset: 0x00088624
			// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x0000EC66 File Offset: 0x0000CE66
			public unsafe FieldInfo fieldInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_fieldInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_fieldInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015D3 RID: 5587
			private static readonly IntPtr NativeFieldInfoPtr_fieldInfo;

			// Token: 0x040015D4 RID: 5588
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015D5 RID: 5589
			private static readonly IntPtr NativeMethodInfoPtr__CreateGet_b__0_Internal_Object_T_0;
		}

		// Token: 0x020001A4 RID: 420
		[ObfuscatedName("Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory+<>c__DisplayClass8_0`1")]
		public sealed class __c__DisplayClass8_0<T> : Object
		{
			// Token: 0x06001DC8 RID: 7624 RVA: 0x0008A454 File Offset: 0x00088654
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass8_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr, "<>c__DisplayClass8_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass8_0<T>>.NativeClassPtr);
				LateBoundReflectionDelegateFactory.__c__DisplayClass8_0<T>.NativeFieldInfoPtr_fieldInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass8_0<T>>.NativeClassPtr, "fieldInfo");
				LateBoundReflectionDelegateFactory.__c__DisplayClass8_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass8_0<T>>.NativeClassPtr, 100664949);
				LateBoundReflectionDelegateFactory.__c__DisplayClass8_0<T>.NativeMethodInfoPtr__CreateSet_b__0_Internal_Void_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass8_0<T>>.NativeClassPtr, 100664950);
			}

			// Token: 0x06001DC9 RID: 7625 RVA: 0x0008A4F8 File Offset: 0x000886F8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass8_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LateBoundReflectionDelegateFactory.__c__DisplayClass8_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DCA RID: 7626 RVA: 0x0008A534 File Offset: 0x00088734
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744479, XrefRangeEnd = 744485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateSet_b__0(T o, Object v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = o;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref o;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LateBoundReflectionDelegateFactory.__c__DisplayClass8_0<T>.NativeMethodInfoPtr__CreateSet_b__0_Internal_Void_T_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x06001DCB RID: 7627 RVA: 0x0000EC85 File Offset: 0x0000CE85
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700086B RID: 2155
			// (get) Token: 0x06001DCC RID: 7628 RVA: 0x0008A5C0 File Offset: 0x000887C0
			// (set) Token: 0x06001DCD RID: 7629 RVA: 0x0000EC8E File Offset: 0x0000CE8E
			public unsafe FieldInfo fieldInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass8_0<T>.NativeFieldInfoPtr_fieldInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass8_0<T>.NativeFieldInfoPtr_fieldInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015D6 RID: 5590
			private static readonly IntPtr NativeFieldInfoPtr_fieldInfo;

			// Token: 0x040015D7 RID: 5591
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015D8 RID: 5592
			private static readonly IntPtr NativeMethodInfoPtr__CreateSet_b__0_Internal_Void_T_Object_0;
		}

		// Token: 0x020001A5 RID: 421
		[ObfuscatedName("Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory+<>c__DisplayClass9_0`1")]
		public sealed class __c__DisplayClass9_0<T> : Object
		{
			// Token: 0x06001DCE RID: 7630 RVA: 0x0008A5F0 File Offset: 0x000887F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass9_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr, "<>c__DisplayClass9_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass9_0<T>>.NativeClassPtr);
				LateBoundReflectionDelegateFactory.__c__DisplayClass9_0<T>.NativeFieldInfoPtr_propertyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass9_0<T>>.NativeClassPtr, "propertyInfo");
				LateBoundReflectionDelegateFactory.__c__DisplayClass9_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass9_0<T>>.NativeClassPtr, 100664951);
				LateBoundReflectionDelegateFactory.__c__DisplayClass9_0<T>.NativeMethodInfoPtr__CreateSet_b__0_Internal_Void_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass9_0<T>>.NativeClassPtr, 100664952);
			}

			// Token: 0x06001DCF RID: 7631 RVA: 0x0008A694 File Offset: 0x00088894
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LateBoundReflectionDelegateFactory.__c__DisplayClass9_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LateBoundReflectionDelegateFactory.__c__DisplayClass9_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DD0 RID: 7632 RVA: 0x0008A6D0 File Offset: 0x000888D0
			[CallerCount(0)]
			public unsafe void _CreateSet_b__0(T o, Object v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = o;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref o;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LateBoundReflectionDelegateFactory.__c__DisplayClass9_0<T>.NativeMethodInfoPtr__CreateSet_b__0_Internal_Void_T_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x06001DD1 RID: 7633 RVA: 0x0000ECAD File Offset: 0x0000CEAD
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700086C RID: 2156
			// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x0008A75C File Offset: 0x0008895C
			// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x0000ECB6 File Offset: 0x0000CEB6
			public unsafe PropertyInfo propertyInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass9_0<T>.NativeFieldInfoPtr_propertyInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LateBoundReflectionDelegateFactory.__c__DisplayClass9_0<T>.NativeFieldInfoPtr_propertyInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015D9 RID: 5593
			private static readonly IntPtr NativeFieldInfoPtr_propertyInfo;

			// Token: 0x040015DA RID: 5594
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015DB RID: 5595
			private static readonly IntPtr NativeMethodInfoPtr__CreateSet_b__0_Internal_Void_T_Object_0;
		}

		// Token: 0x020001A6 RID: 422
		private sealed class MethodInfoStoreGeneric_CreateMethodCall_Public_Virtual_MethodCall_2_T_Object_MethodBase_0<T>
		{
			// Token: 0x040015DC RID: 5596
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LateBoundReflectionDelegateFactory.NativeMethodInfoPtr_CreateMethodCall_Public_Virtual_MethodCall_2_T_Object_MethodBase_0, Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001A7 RID: 423
		private sealed class MethodInfoStoreGeneric_CreateDefaultConstructor_Public_Virtual_Func_1_T_Type_0<T>
		{
			// Token: 0x040015DD RID: 5597
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LateBoundReflectionDelegateFactory.NativeMethodInfoPtr_CreateDefaultConstructor_Public_Virtual_Func_1_T_Type_0, Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001A8 RID: 424
		private sealed class MethodInfoStoreGeneric_CreateGet_Public_Virtual_Func_2_T_Object_PropertyInfo_0<T>
		{
			// Token: 0x040015DE RID: 5598
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LateBoundReflectionDelegateFactory.NativeMethodInfoPtr_CreateGet_Public_Virtual_Func_2_T_Object_PropertyInfo_0, Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001A9 RID: 425
		private sealed class MethodInfoStoreGeneric_CreateGet_Public_Virtual_Func_2_T_Object_FieldInfo_0<T>
		{
			// Token: 0x040015DF RID: 5599
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LateBoundReflectionDelegateFactory.NativeMethodInfoPtr_CreateGet_Public_Virtual_Func_2_T_Object_FieldInfo_0, Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001AA RID: 426
		private sealed class MethodInfoStoreGeneric_CreateSet_Public_Virtual_Action_2_T_Object_FieldInfo_0<T>
		{
			// Token: 0x040015E0 RID: 5600
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LateBoundReflectionDelegateFactory.NativeMethodInfoPtr_CreateSet_Public_Virtual_Action_2_T_Object_FieldInfo_0, Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001AB RID: 427
		private sealed class MethodInfoStoreGeneric_CreateSet_Public_Virtual_Action_2_T_Object_PropertyInfo_0<T>
		{
			// Token: 0x040015E1 RID: 5601
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LateBoundReflectionDelegateFactory.NativeMethodInfoPtr_CreateSet_Public_Virtual_Action_2_T_Object_PropertyInfo_0, Il2CppClassPointerStore<LateBoundReflectionDelegateFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
