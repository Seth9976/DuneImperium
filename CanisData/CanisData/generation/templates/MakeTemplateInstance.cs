using System;
using CanisData.generation.builders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace CanisData.generation.templates
{
	// Token: 0x02000023 RID: 35
	public sealed class MakeTemplateInstance<BuilderType> : MulticastDelegate where BuilderType : ScriptBuilder, new()
	{
		// Token: 0x06000147 RID: 327 RVA: 0x0000851C File Offset: 0x0000671C
		// Note: this type is marked as 'beforefieldinit'.
		static MakeTemplateInstance()
		{
			Il2CppClassPointerStore<MakeTemplateInstance<BuilderType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.generation.templates", "MakeTemplateInstance`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BuilderType>.NativeClassPtr)) })).TypeHandle.value);
			MakeTemplateInstance<BuilderType>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MakeTemplateInstance<BuilderType>>.NativeClassPtr, 100663463);
			MakeTemplateInstance<BuilderType>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ITransformsBuilder_1_BuilderType_BuilderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MakeTemplateInstance<BuilderType>>.NativeClassPtr, 100663464);
			MakeTemplateInstance<BuilderType>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BuilderType_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MakeTemplateInstance<BuilderType>>.NativeClassPtr, 100663465);
			MakeTemplateInstance<BuilderType>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ITransformsBuilder_1_BuilderType_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MakeTemplateInstance<BuilderType>>.NativeClassPtr, 100663466);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000085D0 File Offset: 0x000067D0
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 554431, RefRangeEnd = 554456, XrefRangeStart = 554431, XrefRangeEnd = 554456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MakeTemplateInstance(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MakeTemplateInstance<BuilderType>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MakeTemplateInstance<BuilderType>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000862C File Offset: 0x0000682C
		[CallerCount(0)]
		public unsafe ITransformsBuilder<BuilderType> Invoke(BuilderType builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(BuilderType).IsValueType)
				{
					BuilderType builderType = builder;
					intPtr = ((builderType is string) ? IL2CPP.ManagedStringToIl2Cpp(builderType as string) : IL2CPP.Il2CppObjectBaseToPtr(builderType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref builder;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MakeTemplateInstance<BuilderType>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ITransformsBuilder_1_BuilderType_BuilderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<ITransformsBuilder<BuilderType>>(intPtr4) : null;
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000086B4 File Offset: 0x000068B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(BuilderType builder, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(BuilderType).IsValueType)
				{
					BuilderType builderType = builder;
					intPtr = ((builderType is string) ? IL2CPP.ManagedStringToIl2Cpp(builderType as string) : IL2CPP.Il2CppObjectBaseToPtr(builderType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref builder;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MakeTemplateInstance<BuilderType>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BuilderType_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00008760 File Offset: 0x00006960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ITransformsBuilder<BuilderType> EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MakeTemplateInstance<BuilderType>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ITransformsBuilder_1_BuilderType_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITransformsBuilder<BuilderType>>(intPtr3) : null;
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002A51 File Offset: 0x00000C51
		public MakeTemplateInstance(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002A5A File Offset: 0x00000C5A
		public static implicit operator MakeTemplateInstance<BuilderType>(Func<BuilderType, ITransformsBuilder<BuilderType>> A_0)
		{
			return DelegateSupport.ConvertDelegate<MakeTemplateInstance<BuilderType>>(A_0);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002A62 File Offset: 0x00000C62
		public static MakeTemplateInstance<BuilderType>operator +(MakeTemplateInstance<BuilderType> A_0, MakeTemplateInstance<BuilderType> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<MakeTemplateInstance<BuilderType>>();
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002A70 File Offset: 0x00000C70
		public static MakeTemplateInstance<BuilderType>operator -(MakeTemplateInstance<BuilderType> A_0, MakeTemplateInstance<BuilderType> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<MakeTemplateInstance<BuilderType>>();
			}
			return delegate2;
		}

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ITransformsBuilder_1_BuilderType_BuilderType_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BuilderType_AsyncCallback_Object_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ITransformsBuilder_1_BuilderType_IAsyncResult_0;
	}
}
