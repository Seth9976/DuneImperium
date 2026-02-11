using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000023 RID: 35
	public sealed class DeadZoneFunc : MulticastDelegate
	{
		// Token: 0x0600025D RID: 605 RVA: 0x000104D8 File Offset: 0x0000E6D8
		// Note: this type is marked as 'beforefieldinit'.
		static DeadZoneFunc()
		{
			Il2CppClassPointerStore<DeadZoneFunc>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "DeadZoneFunc");
			DeadZoneFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadZoneFunc>.NativeClassPtr, 100663626);
			DeadZoneFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector2_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadZoneFunc>.NativeClassPtr, 100663627);
			DeadZoneFunc.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_Single_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadZoneFunc>.NativeClassPtr, 100663628);
			DeadZoneFunc.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector2_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadZoneFunc>.NativeClassPtr, 100663629);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00010550 File Offset: 0x0000E750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769318, XrefRangeEnd = 769321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeadZoneFunc(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeadZoneFunc>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadZoneFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000105AC File Offset: 0x0000E7AC
		[CallerCount(0)]
		public unsafe Vector2 Invoke(float x, float y, float lowerDeadZone, float upperDeadZone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowerDeadZone;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref upperDeadZone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadZoneFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector2_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00010620 File Offset: 0x0000E820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769321, XrefRangeEnd = 769331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(float x, float y, float lowerDeadZone, float upperDeadZone, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowerDeadZone;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref upperDeadZone;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadZoneFunc.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_Single_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000106BC File Offset: 0x0000E8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadZoneFunc.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector2_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002DDB File Offset: 0x00000FDB
		public DeadZoneFunc(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002DE4 File Offset: 0x00000FE4
		public static implicit operator DeadZoneFunc(Func<float, float, float, float, Vector2> A_0)
		{
			return DelegateSupport.ConvertDelegate<DeadZoneFunc>(A_0);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002DEC File Offset: 0x00000FEC
		public static DeadZoneFunc operator +(DeadZoneFunc A_0, DeadZoneFunc A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<DeadZoneFunc>();
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002DFA File Offset: 0x00000FFA
		public static DeadZoneFunc operator -(DeadZoneFunc A_0, DeadZoneFunc A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<DeadZoneFunc>();
			}
			return delegate2;
		}

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector2_Single_Single_Single_Single_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_Single_Single_AsyncCallback_Object_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector2_IAsyncResult_0;
	}
}
