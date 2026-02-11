using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace lotus
{
	// Token: 0x02000068 RID: 104
	public class PathAnimator : MonoBehaviour
	{
		// Token: 0x06000624 RID: 1572 RVA: 0x0001DC10 File Offset: 0x0001BE10
		// Note: this type is marked as 'beforefieldinit'.
		static PathAnimator()
		{
			Il2CppClassPointerStore<PathAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "PathAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathAnimator>.NativeClassPtr);
			PathAnimator.NativeFieldInfoPtr_OnUnblock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathAnimator>.NativeClassPtr, "OnUnblock");
			PathAnimator.NativeFieldInfoPtr_OnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathAnimator>.NativeClassPtr, "OnComplete");
			PathAnimator.NativeMethodInfoPtr_InitWithContext_Public_Abstract_Virtual_New_Void_UnitView_UnitPosition_LocalTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathAnimator>.NativeClassPtr, 100664138);
			PathAnimator.NativeMethodInfoPtr_Play_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathAnimator>.NativeClassPtr, 100664139);
			PathAnimator.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathAnimator>.NativeClassPtr, 100664140);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0001DCA4 File Offset: 0x0001BEA4
		[CallerCount(0)]
		public unsafe virtual void InitWithContext(UnitView unitView, UnitPosition unitPosition, LocalTransform destLocalTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unitView);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unitPosition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLocalTransform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathAnimator.NativeMethodInfoPtr_InitWithContext_Public_Abstract_Virtual_New_Void_UnitView_UnitPosition_LocalTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0001DD14 File Offset: 0x0001BF14
		[CallerCount(0)]
		public unsafe virtual void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathAnimator.NativeMethodInfoPtr_Play_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0001DD50 File Offset: 0x0001BF50
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathAnimator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathAnimator.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0000506F File Offset: 0x0000326F
		public PathAnimator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x0001DD8C File Offset: 0x0001BF8C
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x00005078 File Offset: 0x00003278
		public unsafe PathAnimator.UnblockDelegate OnUnblock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathAnimator.NativeFieldInfoPtr_OnUnblock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathAnimator.UnblockDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathAnimator.NativeFieldInfoPtr_OnUnblock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x0001DDBC File Offset: 0x0001BFBC
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x00005097 File Offset: 0x00003297
		public unsafe PathAnimator.OnCompleteDelegate OnComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathAnimator.NativeFieldInfoPtr_OnComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathAnimator.OnCompleteDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathAnimator.NativeFieldInfoPtr_OnComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeFieldInfoPtr_OnUnblock;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeFieldInfoPtr_OnComplete;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_InitWithContext_Public_Abstract_Virtual_New_Void_UnitView_UnitPosition_LocalTransform_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020000ED RID: 237
		public sealed class UnblockDelegate : MulticastDelegate
		{
			// Token: 0x06000C5B RID: 3163 RVA: 0x000317BC File Offset: 0x0002F9BC
			// Note: this type is marked as 'beforefieldinit'.
			static UnblockDelegate()
			{
				Il2CppClassPointerStore<PathAnimator.UnblockDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PathAnimator>.NativeClassPtr, "UnblockDelegate");
				PathAnimator.UnblockDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathAnimator.UnblockDelegate>.NativeClassPtr, 100664141);
				PathAnimator.UnblockDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathAnimator.UnblockDelegate>.NativeClassPtr, 100664142);
				PathAnimator.UnblockDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathAnimator.UnblockDelegate>.NativeClassPtr, 100664143);
				PathAnimator.UnblockDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathAnimator.UnblockDelegate>.NativeClassPtr, 100664144);
			}

			// Token: 0x06000C5C RID: 3164 RVA: 0x00031830 File Offset: 0x0002FA30
			[CallerCount(288)]
			[CachedScanResults(RefRangeStart = 320972, RefRangeEnd = 321260, XrefRangeStart = 320972, XrefRangeEnd = 321260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnblockDelegate(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathAnimator.UnblockDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathAnimator.UnblockDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C5D RID: 3165 RVA: 0x0003188C File Offset: 0x0002FA8C
			[CallerCount(0)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathAnimator.UnblockDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C5E RID: 3166 RVA: 0x000318C0 File Offset: 0x0002FAC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathAnimator.UnblockDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000C5F RID: 3167 RVA: 0x00031924 File Offset: 0x0002FB24
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathAnimator.UnblockDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C60 RID: 3168 RVA: 0x00008177 File Offset: 0x00006377
			public UnblockDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000C61 RID: 3169 RVA: 0x00008180 File Offset: 0x00006380
			public static implicit operator PathAnimator.UnblockDelegate(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<PathAnimator.UnblockDelegate>(A_0);
			}

			// Token: 0x06000C62 RID: 3170 RVA: 0x00008188 File Offset: 0x00006388
			public static PathAnimator.UnblockDelegate operator +(PathAnimator.UnblockDelegate A_0, PathAnimator.UnblockDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PathAnimator.UnblockDelegate>();
			}

			// Token: 0x06000C63 RID: 3171 RVA: 0x00008196 File Offset: 0x00006396
			public static PathAnimator.UnblockDelegate operator -(PathAnimator.UnblockDelegate A_0, PathAnimator.UnblockDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PathAnimator.UnblockDelegate>();
				}
				return delegate2;
			}

			// Token: 0x040007B1 RID: 1969
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040007B2 RID: 1970
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x040007B3 RID: 1971
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x040007B4 RID: 1972
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020000EE RID: 238
		public sealed class OnCompleteDelegate : MulticastDelegate
		{
			// Token: 0x06000C64 RID: 3172 RVA: 0x00031968 File Offset: 0x0002FB68
			// Note: this type is marked as 'beforefieldinit'.
			static OnCompleteDelegate()
			{
				Il2CppClassPointerStore<PathAnimator.OnCompleteDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PathAnimator>.NativeClassPtr, "OnCompleteDelegate");
				PathAnimator.OnCompleteDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathAnimator.OnCompleteDelegate>.NativeClassPtr, 100664145);
				PathAnimator.OnCompleteDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathAnimator.OnCompleteDelegate>.NativeClassPtr, 100664146);
				PathAnimator.OnCompleteDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathAnimator.OnCompleteDelegate>.NativeClassPtr, 100664147);
				PathAnimator.OnCompleteDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathAnimator.OnCompleteDelegate>.NativeClassPtr, 100664148);
			}

			// Token: 0x06000C65 RID: 3173 RVA: 0x000319DC File Offset: 0x0002FBDC
			[CallerCount(288)]
			[CachedScanResults(RefRangeStart = 320972, RefRangeEnd = 321260, XrefRangeStart = 320972, XrefRangeEnd = 321260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnCompleteDelegate(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathAnimator.OnCompleteDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathAnimator.OnCompleteDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C66 RID: 3174 RVA: 0x00031A38 File Offset: 0x0002FC38
			[CallerCount(0)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathAnimator.OnCompleteDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C67 RID: 3175 RVA: 0x00031A6C File Offset: 0x0002FC6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathAnimator.OnCompleteDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000C68 RID: 3176 RVA: 0x00031AD0 File Offset: 0x0002FCD0
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathAnimator.OnCompleteDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C69 RID: 3177 RVA: 0x000081A7 File Offset: 0x000063A7
			public OnCompleteDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000C6A RID: 3178 RVA: 0x000081B0 File Offset: 0x000063B0
			public static implicit operator PathAnimator.OnCompleteDelegate(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<PathAnimator.OnCompleteDelegate>(A_0);
			}

			// Token: 0x06000C6B RID: 3179 RVA: 0x000081B8 File Offset: 0x000063B8
			public static PathAnimator.OnCompleteDelegate operator +(PathAnimator.OnCompleteDelegate A_0, PathAnimator.OnCompleteDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PathAnimator.OnCompleteDelegate>();
			}

			// Token: 0x06000C6C RID: 3180 RVA: 0x000081C6 File Offset: 0x000063C6
			public static PathAnimator.OnCompleteDelegate operator -(PathAnimator.OnCompleteDelegate A_0, PathAnimator.OnCompleteDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PathAnimator.OnCompleteDelegate>();
				}
				return delegate2;
			}

			// Token: 0x040007B5 RID: 1973
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040007B6 RID: 1974
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x040007B7 RID: 1975
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x040007B8 RID: 1976
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
