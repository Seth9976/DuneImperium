using System;
using CanisData.generation.builders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace CanisData.generation.generators
{
	// Token: 0x02000026 RID: 38
	public sealed class BuilderDecorator<BuilderType> : MulticastDelegate where BuilderType : ScriptBuilder, new()
	{
		// Token: 0x06000165 RID: 357 RVA: 0x00008C30 File Offset: 0x00006E30
		// Note: this type is marked as 'beforefieldinit'.
		static BuilderDecorator()
		{
			Il2CppClassPointerStore<BuilderDecorator<BuilderType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.generation.generators", "BuilderDecorator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BuilderType>.NativeClassPtr)) })).TypeHandle.value);
			BuilderDecorator<BuilderType>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuilderDecorator<BuilderType>>.NativeClassPtr, 100663474);
			BuilderDecorator<BuilderType>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_BuilderType_BuilderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuilderDecorator<BuilderType>>.NativeClassPtr, 100663475);
			BuilderDecorator<BuilderType>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BuilderType_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuilderDecorator<BuilderType>>.NativeClassPtr, 100663476);
			BuilderDecorator<BuilderType>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_BuilderType_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuilderDecorator<BuilderType>>.NativeClassPtr, 100663477);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00008CE4 File Offset: 0x00006EE4
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 554431, RefRangeEnd = 554456, XrefRangeStart = 554431, XrefRangeEnd = 554456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuilderDecorator(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuilderDecorator<BuilderType>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuilderDecorator<BuilderType>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00008D40 File Offset: 0x00006F40
		[CallerCount(0)]
		public unsafe BuilderType Invoke(BuilderType builder)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BuilderDecorator<BuilderType>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_BuilderType_BuilderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<BuilderType>(intPtr2, false, true);
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00008DC0 File Offset: 0x00006FC0
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BuilderDecorator<BuilderType>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BuilderType_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00008E6C File Offset: 0x0000706C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuilderType EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuilderDecorator<BuilderType>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_BuilderType_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<BuilderType>(intPtr, false, true);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002B2E File Offset: 0x00000D2E
		public BuilderDecorator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002B37 File Offset: 0x00000D37
		public static implicit operator BuilderDecorator<BuilderType>(Func<BuilderType, BuilderType> A_0)
		{
			return DelegateSupport.ConvertDelegate<BuilderDecorator<BuilderType>>(A_0);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002B3F File Offset: 0x00000D3F
		public static BuilderDecorator<BuilderType>operator +(BuilderDecorator<BuilderType> A_0, BuilderDecorator<BuilderType> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<BuilderDecorator<BuilderType>>();
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002B4D File Offset: 0x00000D4D
		public static BuilderDecorator<BuilderType>operator -(BuilderDecorator<BuilderType> A_0, BuilderDecorator<BuilderType> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<BuilderDecorator<BuilderType>>();
			}
			return delegate2;
		}

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_BuilderType_BuilderType_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BuilderType_AsyncCallback_Object_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_BuilderType_IAsyncResult_0;
	}
}
