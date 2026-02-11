using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000013 RID: 19
	public sealed class RenderFunc<PassData> : MulticastDelegate where PassData : class, new()
	{
		// Token: 0x06000176 RID: 374 RVA: 0x00012818 File Offset: 0x00010A18
		// Note: this type is marked as 'beforefieldinit'.
		static RenderFunc()
		{
			Il2CppClassPointerStore<RenderFunc<PassData>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RenderFunc`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PassData>.NativeClassPtr)) })).TypeHandle.value);
			RenderFunc<PassData>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderFunc<PassData>>.NativeClassPtr, 100663433);
			RenderFunc<PassData>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderFunc<PassData>>.NativeClassPtr, 100663434);
			RenderFunc<PassData>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PassData_RenderGraphContext_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderFunc<PassData>>.NativeClassPtr, 100663435);
			RenderFunc<PassData>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderFunc<PassData>>.NativeClassPtr, 100663436);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000128CC File Offset: 0x00010ACC
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderFunc(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderFunc<PassData>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderFunc<PassData>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00012928 File Offset: 0x00010B28
		[CallerCount(0)]
		public unsafe void Invoke(PassData data, RenderGraphContext renderGraphContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(PassData).IsValueType)
				{
					PassData passData = data;
					intPtr = ((passData is string) ? IL2CPP.ManagedStringToIl2Cpp(passData as string) : IL2CPP.Il2CppObjectBaseToPtr(passData as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref data;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderGraphContext);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RenderFunc<PassData>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000129B4 File Offset: 0x00010BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(PassData data, RenderGraphContext renderGraphContext, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(PassData).IsValueType)
				{
					PassData passData = data;
					intPtr = ((passData is string) ? IL2CPP.ManagedStringToIl2Cpp(passData as string) : IL2CPP.Il2CppObjectBaseToPtr(passData as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref data;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderGraphContext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RenderFunc<PassData>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PassData_RenderGraphContext_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00012A74 File Offset: 0x00010C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderFunc<PassData>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002AB5 File Offset: 0x00000CB5
		public RenderFunc(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002ABE File Offset: 0x00000CBE
		public static implicit operator RenderFunc<PassData>(Action<PassData, RenderGraphContext> A_0)
		{
			return DelegateSupport.ConvertDelegate<RenderFunc<PassData>>(A_0);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002AC6 File Offset: 0x00000CC6
		public static RenderFunc<PassData>operator +(RenderFunc<PassData> A_0, RenderFunc<PassData> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<RenderFunc<PassData>>();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002AD4 File Offset: 0x00000CD4
		public static RenderFunc<PassData>operator -(RenderFunc<PassData> A_0, RenderFunc<PassData> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<RenderFunc<PassData>>();
			}
			return delegate2;
		}

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PassData_RenderGraphContext_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PassData_RenderGraphContext_AsyncCallback_Object_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
