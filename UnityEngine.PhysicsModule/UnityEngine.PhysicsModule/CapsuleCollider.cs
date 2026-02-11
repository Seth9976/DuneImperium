using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	public class CapsuleCollider : Collider
	{
		// Token: 0x0600026C RID: 620 RVA: 0x000098EC File Offset: 0x00007AEC
		// Note: this type is marked as 'beforefieldinit'.
		static CapsuleCollider()
		{
			Il2CppClassPointerStore<CapsuleCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "CapsuleCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CapsuleCollider>.NativeClassPtr);
			CapsuleCollider.get_radiusDelegateField = IL2CPP.ResolveICall<CapsuleCollider.get_radiusDelegate>("UnityEngine.CapsuleCollider::get_radius");
			CapsuleCollider.set_radiusDelegateField = IL2CPP.ResolveICall<CapsuleCollider.set_radiusDelegate>("UnityEngine.CapsuleCollider::set_radius");
			CapsuleCollider.get_heightDelegateField = IL2CPP.ResolveICall<CapsuleCollider.get_heightDelegate>("UnityEngine.CapsuleCollider::get_height");
			CapsuleCollider.set_heightDelegateField = IL2CPP.ResolveICall<CapsuleCollider.set_heightDelegate>("UnityEngine.CapsuleCollider::set_height");
			CapsuleCollider.get_directionDelegateField = IL2CPP.ResolveICall<CapsuleCollider.get_directionDelegate>("UnityEngine.CapsuleCollider::get_direction");
			CapsuleCollider.set_directionDelegateField = IL2CPP.ResolveICall<CapsuleCollider.set_directionDelegate>("UnityEngine.CapsuleCollider::set_direction");
			CapsuleCollider.get_center_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCollider.get_center_InjectedDelegate>("UnityEngine.CapsuleCollider::get_center_Injected");
			CapsuleCollider.set_center_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCollider.set_center_InjectedDelegate>("UnityEngine.CapsuleCollider::set_center_Injected");
			CapsuleCollider.GetGlobalExtents_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCollider.GetGlobalExtents_InjectedDelegate>("UnityEngine.CapsuleCollider::GetGlobalExtents_Injected");
			CapsuleCollider.CalculateTransform_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCollider.CalculateTransform_InjectedDelegate>("UnityEngine.CapsuleCollider::CalculateTransform_Injected");
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00003358 File Offset: 0x00001558
		public CapsuleCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600026E RID: 622 RVA: 0x000099B4 File Offset: 0x00007BB4
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00003361 File Offset: 0x00001561
		public Vector3 center
		{
			get
			{
				Vector3 vector;
				this.get_center_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_center_Injected(ref value);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0000336B File Offset: 0x0000156B
		// (set) Token: 0x06000271 RID: 625 RVA: 0x0000337D File Offset: 0x0000157D
		public float radius
		{
			get
			{
				return CapsuleCollider.get_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CapsuleCollider.set_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00003390 File Offset: 0x00001590
		// (set) Token: 0x06000273 RID: 627 RVA: 0x000033A2 File Offset: 0x000015A2
		public float height
		{
			get
			{
				return CapsuleCollider.get_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CapsuleCollider.set_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000274 RID: 628 RVA: 0x000033B5 File Offset: 0x000015B5
		// (set) Token: 0x06000275 RID: 629 RVA: 0x000033C7 File Offset: 0x000015C7
		public int direction
		{
			get
			{
				return CapsuleCollider.get_directionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CapsuleCollider.set_directionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000099CC File Offset: 0x00007BCC
		public Vector2 GetGlobalExtents()
		{
			Vector2 vector;
			this.GetGlobalExtents_Injected(out vector);
			return vector;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x000099E4 File Offset: 0x00007BE4
		public Matrix4x4 CalculateTransform()
		{
			Matrix4x4 matrix4x;
			this.CalculateTransform_Injected(out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x000033DA File Offset: 0x000015DA
		public void get_center_Injected(out Vector3 ret)
		{
			CapsuleCollider.get_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000033ED File Offset: 0x000015ED
		public void set_center_Injected(ref Vector3 value)
		{
			CapsuleCollider.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00003400 File Offset: 0x00001600
		public void GetGlobalExtents_Injected(out Vector2 ret)
		{
			CapsuleCollider.GetGlobalExtents_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00003413 File Offset: 0x00001613
		public void CalculateTransform_Injected(out Matrix4x4 ret)
		{
			CapsuleCollider.CalculateTransform_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0400015D RID: 349
		private static readonly CapsuleCollider.get_radiusDelegate get_radiusDelegateField;

		// Token: 0x0400015E RID: 350
		private static readonly CapsuleCollider.set_radiusDelegate set_radiusDelegateField;

		// Token: 0x0400015F RID: 351
		private static readonly CapsuleCollider.get_heightDelegate get_heightDelegateField;

		// Token: 0x04000160 RID: 352
		private static readonly CapsuleCollider.set_heightDelegate set_heightDelegateField;

		// Token: 0x04000161 RID: 353
		private static readonly CapsuleCollider.get_directionDelegate get_directionDelegateField;

		// Token: 0x04000162 RID: 354
		private static readonly CapsuleCollider.set_directionDelegate set_directionDelegateField;

		// Token: 0x04000163 RID: 355
		private static readonly CapsuleCollider.get_center_InjectedDelegate get_center_InjectedDelegateField;

		// Token: 0x04000164 RID: 356
		private static readonly CapsuleCollider.set_center_InjectedDelegate set_center_InjectedDelegateField;

		// Token: 0x04000165 RID: 357
		private static readonly CapsuleCollider.GetGlobalExtents_InjectedDelegate GetGlobalExtents_InjectedDelegateField;

		// Token: 0x04000166 RID: 358
		private static readonly CapsuleCollider.CalculateTransform_InjectedDelegate CalculateTransform_InjectedDelegateField;

		// Token: 0x020000E6 RID: 230
		// (Invoke) Token: 0x060005A4 RID: 1444
		private delegate float get_radiusDelegate(IntPtr @this);

		// Token: 0x020000E7 RID: 231
		// (Invoke) Token: 0x060005A6 RID: 1446
		private delegate void set_radiusDelegate(IntPtr @this, float value);

		// Token: 0x020000E8 RID: 232
		// (Invoke) Token: 0x060005A8 RID: 1448
		private delegate float get_heightDelegate(IntPtr @this);

		// Token: 0x020000E9 RID: 233
		// (Invoke) Token: 0x060005AA RID: 1450
		private delegate void set_heightDelegate(IntPtr @this, float value);

		// Token: 0x020000EA RID: 234
		// (Invoke) Token: 0x060005AC RID: 1452
		private delegate int get_directionDelegate(IntPtr @this);

		// Token: 0x020000EB RID: 235
		// (Invoke) Token: 0x060005AE RID: 1454
		private delegate void set_directionDelegate(IntPtr @this, int value);

		// Token: 0x020000EC RID: 236
		// (Invoke) Token: 0x060005B0 RID: 1456
		private delegate void get_center_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000ED RID: 237
		// (Invoke) Token: 0x060005B2 RID: 1458
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000EE RID: 238
		// (Invoke) Token: 0x060005B4 RID: 1460
		private delegate void GetGlobalExtents_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000EF RID: 239
		// (Invoke) Token: 0x060005B6 RID: 1462
		private delegate void CalculateTransform_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
